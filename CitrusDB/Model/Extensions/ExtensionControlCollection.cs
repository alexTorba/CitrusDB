﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitrusDB.Model.Entity;
using CitrusDB.Model.DataBaseLogic;
using CitrusDB.View;
using static System.Windows.Forms.Control;

namespace CitrusDB.Model.Extensions
{
  public static class ExtensionControlCollection
  {
    /// <summary>
    /// Delete students from ControlCollection
    /// </summary>
    /// <param name="controlCollection"></param>
    /// <param name="changedEntities">Entities that was changed</param>
    /// <param name="storedEntities">Entities that store in DB </param>
    /// <param name="token">Cancellation token</param>
    public static async Task DeleteControls<T>(
      this ControlCollection controlCollection,
      IEnumerable<T> changedEntities,
      IEnumerable<T> storedEntities,
      CancellationToken token)
      where T : IEntity
    {
      var controls = new List<Control>();

      Console.WriteLine($"DeleteControls: changedEntities - {changedEntities.Count()}");

      await Task.Factory.StartNew(() =>
      {
        foreach (var entity in changedEntities)
        {
          var control = controlCollection
            .Cast<IEntity>()
            .FirstOrDefault(c => c.Id == entity.Id);
          controls.Add((Control) control);
        }

        //entity that doesnt store in db and was deleted 
        var entityIDs = controlCollection
          .Cast<IEntity>()
          .Select(sv => sv.Id);

        var storedEntityIDs = storedEntities.Select(s => s.Id);

        entityIDs.Except(storedEntityIDs)
          .Select(id => controlCollection
            .Cast<IEntity>()
            .First(st => st.Id == id)).ToList()
          .ForEach(c => controls.Add((Control) c));
      }, token);

      controls.ForEach(controlCollection.Remove);
    }

    public static async void DeleteControls<T>(
      this ControlCollection controlCollection,
      IEnumerable<T> changedEntities,
      CancellationToken token)
      where T : IEntity
    {
      var controls = new List<Control>();

      await Task.Factory.StartNew(() =>
      {
        foreach (var entity in changedEntities)
        {
          var control = controlCollection
            .Cast<IEntity>()
            .FirstOrDefault(c => c.Id == entity.Id);
          controls.Add((Control) control);
        }
      }, token);

      controls.ForEach(controlCollection.Remove);
    }

    /// <summary>
    /// Transformation of entities into controls and adding them to the collection
    /// </summary>
    /// <typeparam name="T">Type of entity</typeparam>
    /// <typeparam name="R">Type of control that the entity represents</typeparam>
    /// <param name="controlCollection"></param>
    /// <param name="newEntity">Entities that need to be transformed into controls and added to the collection</param>
    /// <param name="entityControlView">Сontrol in which entities will be transformed</param>
    /// <param name="token">Cancellation token</param>
    /// <returns></returns>
    public static async Task AddControls<T, R>(
      this ControlCollection controlCollection,
      IList<T> newEntity,
      R entityControlView,
      CancellationToken token)
      where T : IEntity
      where R : IEntityControlView<T>
    {
      if (newEntity.Count == 0)
        return;

      var controls = await newEntity.CreateControlCollectionAsync(entityControlView, token);

      controlCollection.AddRange(controls);
    }

    public static async Task UpdateControls<T, R>(this ControlCollection controlCollection,
      IList<T> editEntities,
      R entityControlView,
      CancellationToken token)
      where T : IEntity
      where R : IEntityControlView<T>
    {
      if (editEntities.Count == 0)
        return;

      var controls = (Control[]) null;
      var currentControl = (IEnumerable<IEntityControlView<T>>) null;

      await Task.Factory.StartNew(() =>
      {
        controls = editEntities.CreateControlCollection(entityControlView, token);

        currentControl = controlCollection?.Cast<IEntityControlView<T>>();
      }, TaskCreationOptions.AttachedToParent);

      foreach (IEntityControlView<T> control in controls)
        currentControl.FirstOrDefault(c => c.Id == control.Id)?.SetCopy(control);
    }

    private static async Task<Control[]> CreateControlCollectionAsync<T, R>(
      this IList<T> entities,
      R entityControlView,
      CancellationToken token)
      where T : IEntity
      where R : IEntityControlView<T>
    {
      var arrControls = new Control[entities.Count()];

      await Task.Factory.StartNew(() =>
      {
        var result = entityControlView.CreateListViews(entities.Count());

        for (int i = 0; i < result.Length; i++)
        {
          arrControls[i] = (Control) result[i].FillView(entities[i]);
        }
      }, token);

      return arrControls;
    }

    public static Control[] CreateControlCollection<T, R>(
      this IList<T> entities,
      R entityControlView,
      CancellationToken token)
      where T : IEntity
      where R : IEntityControlView<T>
    {
      var arrControls = new Control[entities.Count];

      var result = entityControlView.CreateListViews(entities.Count);

      for (var i = 0; i < result.Length; i++)
      {
        arrControls[i] = (Control) result[i].FillView(entities[i]);
      }

      return arrControls;
    }

    //if collections are equal, cleaning will not occur
    private static async Task<bool> СollectionEqualityTest<T>(
      this ControlCollection controlCollection,
      IList<T> newEntity,
      CancellationToken token)
      where T : class, IEntity
    {
      return await Task<bool>.Factory.StartNew(() =>
      {
        var countSameValues = controlCollection.Count == newEntity.Count()
          ? newEntity.Count(nE => !controlCollection.IsContainControl<T>(nE.Id))
          : -1;

        Console.WriteLine($"countSameValues - {countSameValues}");

        return countSameValues == 0;
      }, token);
    }

    public static async Task FillControlCollectionForSearch<T, R>(
      this ControlCollection controlCollection,
      IList<T> entities,
      R entityControlView,
      CancellationToken token)
      where T : class, IEntity
      where R : IEntityControlView<T>
    {
      if (await controlCollection.СollectionEqualityTest(entities, token))
        return;

      var controls = await entities.CreateControlCollectionAsync(entityControlView, token);

      controlCollection.Clear();

      controlCollection.AddRange(controls);
    }

    public static bool IsContainControl<T>(this ControlCollection controlCollection, int id) where T : class, IEntity
    {
      return controlCollection.Cast<IEntityControlView<T>>().FirstOrDefault(c => c.Id == id) != null;
    }

    public static async Task<IList<TResult>> TransformControlsToEntitiesAsync<TResult>(
      this ControlCollection controlCollection, CancellationToken token)
      where TResult : class, IEntity
    {
      return await Task.Run(() =>
      {
        var entities = new List<TResult>(controlCollection.Count);
        
        entities.AddRange(controlCollection.Cast<IEntityControlView<TResult>>()
          .Select(control => EFGenericRepository.Find<TResult>(control.Id)));

        return entities;
      }, token);
    }

    public static IList<TResult> TransformControlsToEntities<TResult>(this ControlCollection controlCollection)
      where TResult : class, IEntity
    {
      var entities = new List<TResult>(controlCollection.Count);
      
      entities.AddRange(controlCollection.Cast<IEntityControlView<TResult>>()
        .Select(control => EFGenericRepository.Find<TResult>(control.Id)));

      return entities;
    }
  }
}