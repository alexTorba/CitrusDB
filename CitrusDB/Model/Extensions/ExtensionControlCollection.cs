using System;
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
        /// <param name="token">Cancalation token</param>
        public static async Task DeleteControls<T>(
            this ControlCollection controlCollection,
            IEnumerable<T> changedEntities,
            IEnumerable<T> storedEntities,
            CancellationToken token)
            where T : IEntity
        {
            List<Control> controls = new List<Control>();

            Console.WriteLine($"DeleteControls: changedEntities - {changedEntities.Count()}");

            await Task.Factory.StartNew(() =>
            {
                //???
                foreach (var entity in changedEntities)
                {
                    var control = controlCollection
                       .Cast<IEntity>()
                       .Where(c => c.Id == entity.Id)
                       .FirstOrDefault();
                    controls.Add((Control)control);
                }

                //entity that doesnt store in db and was deleted 
                var entityIDs = controlCollection
                .Cast<IEntity>()
                .Select(sv => sv.Id);

                var storedEntityIDs = storedEntities.Select(s => s.Id);

                entityIDs.Except(storedEntityIDs)
               .Select(id =>
                           controlCollection
                           .Cast<IEntity>()
                           .First(st => st.Id == id)).ToList()
                                                              .ForEach(c => controls.Add((Control)c));
            }, token);

            controls.ForEach(c => controlCollection.Remove(c));
        }

        public static async void DeleteControls<T>(
            this ControlCollection controlCollection,
            IEnumerable<T> changedEntities,
            CancellationToken token)
            where T : IEntity
        {
            List<Control> controls = new List<Control>();

            await Task.Factory.StartNew(() =>
            {
                //???
                foreach (var entity in changedEntities)
                {
                    var control = controlCollection
                       .Cast<IEntity>()
                       .Where(c => c.Id == entity.Id)
                       .FirstOrDefault();
                    controls.Add((Control)control);
                }

            }, token);

            controls.ForEach(c => controlCollection.Remove(c));
        }

        /// <summary>
        /// Transformation of entities into controls and adding them to the collection
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <typeparam name="R">Type of control that the entity represents</typeparam>
        /// <param name="controlCollection"></param>
        /// <param name="newEntity">Entities that need to be transformed into controls and added to the collection</param>
        /// <param name="entityControlView">Сontrol in which entities will be transformed</param>
        /// <param name="token">Cancalation token</param>
        /// <returns></returns>
        public static async void AddControls<T, R>(
            this ControlCollection controlCollection,
            IList<T> newEntity,
            R entityControlView,
            CancellationToken token)
            where T : IEntity
            where R : IEntityControlView<T>
        {
            if (newEntity.Count == 0)
                return;

            Control[] controls = await newEntity.CreateControlCollectionAsync(entityControlView, token);

            controlCollection.AddRange(controls);
        }

        public static async Task UpdateControls<T, R>(
            this ControlCollection controlCollection,
            IList<T> editEntities,
            R entityControlView,
            CancellationToken token)
            where T : IEntity
            where R : IEntityControlView<T>
        {
            if (editEntities.Count == 0)
                return;

            Control[] controls = null;
            IEnumerable<IEntityControlView<T>> currentControl = null;

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
            Control[] arrControls = new Control[entities.Count()];

            await Task.Factory.StartNew(() =>
            {
                var result = entityControlView.CreateListViews(entities.Count());

                for (int i = 0; i < result.Length; i++)
                {
                    arrControls[i] = (Control)result[i].FillView(entities[i]);
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
            Control[] arrControls = new Control[entities.Count()];

            var result = entityControlView.CreateListViews(entities.Count());

            for (int i = 0; i < result.Length; i++)
            {
                arrControls[i] = (Control)result[i].FillView(entities[i]);
            }

            return arrControls;
        }

        //if collections are equal, cleaning will not occur
        public static async Task<bool> СollectionEqualityTest<T>(
            this ControlCollection controlCollection,
            IList<T> newEntity,
            CancellationToken token)
            where T : class, IEntity
        {
            return await Task<bool>.Factory.StartNew(() =>
            {
                int countSameValues = controlCollection.Count == newEntity.Count()
                                   ? newEntity
                                   .Where(nE => !controlCollection.IsContaintControl<T>(nE.Id)).Count()
                                   : -1;

                Console.WriteLine($"countSameValues - {countSameValues}");


                if (countSameValues == 0)
                    return true;

                return false;
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

        public static bool IsContaintControl<T>(this ControlCollection controlCollection, int id) where T : class, IEntity
        {
            return controlCollection.Cast<IEntityControlView<T>>().FirstOrDefault(c => c.Id == id) != null
                ? true
                : false;
        }

        public async static Task<IList<TResult>> TransformControlsToEntitiesAsync<TResult>(this ControlCollection controlCollection, CancellationToken token)
            where TResult : class, IEntity
        {
            return await Task.Run(() =>
            {
                List<TResult> entities = new List<TResult>(controlCollection.Count);

                foreach (var control in controlCollection?.Cast<IEntityControlView<TResult>>())
                    entities.Add(EFGenericRepository.Find<TResult>(control.Id));

                return entities;
            }, token);
        }

        public static IList<TResult> TransformControlsToEntities<TResult>(this ControlCollection controlCollection)
            where TResult : class, IEntity
        {
            List<TResult> entities = new List<TResult>(controlCollection.Count);

            foreach (var control in controlCollection?.Cast<IEntityControlView<TResult>>())
                entities.Add(EFGenericRepository.Find<TResult>(control.Id));

            return entities;
        }

    }
}
