using CitrusDB.Model.Entity;
using CitrusDB.View;
using CitrusDB.View.AddGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public static async Task DeleteControlsFromControlCollection<T>(
            this ControlCollection controlCollection,
            IEnumerable<T> changedEntities,
            IEnumerable<T> storedEntities,
            CancellationToken token)
            where T : IEntity
        {
            List<Control> controls = new List<Control>();

            await Task.Factory.StartNew(() =>
            {
                //students that was changed in program and store in local
                if (changedEntities.Count() == 0)
                {
                    foreach (var entity in changedEntities)
                    {
                        var control = controlCollection
                           .Cast<IEntity>()
                           .Where(c => c.Id == entity.Id)
                           .FirstOrDefault();
                        controls.Add((Control)control);
                    }
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
            Control[] controls = await newEntity.CreateControlCollection(entityControlView, token);

            controlCollection.AddRange(controls);
        }

        private static async Task<Control[]> CreateControlCollection<T, R>(
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

        public static async Task<bool> СollectionEqualityTest<T>(
            this ControlCollection controlCollection,
            IList<T> newEntity,
            CancellationToken token)
            where T : IEntity
        {
            return await Task<bool>.Factory.StartNew(() =>
            {
                int countSameValues = controlCollection.Count == newEntity.Count()
                                   ? newEntity
                                   .Where(nE => !controlCollection.IsContaintControl(nE.Id)).Count()
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
            where T : IEntity
            where R : IEntityControlView<T>
        {

            if (await controlCollection.СollectionEqualityTest(entities, token))
                return;

            var controls = await entities.CreateControlCollection(entityControlView, token);

            controlCollection.Clear();

            controlCollection.AddRange(controls);
        }

        public static bool IsContaintControl(this ControlCollection controlCollection, int id)
        {
            return controlCollection.Cast<IStudentView>().FirstOrDefault(c => c.GetStudentId == id) != null
                ? true
                : false;
        }

    }
}
