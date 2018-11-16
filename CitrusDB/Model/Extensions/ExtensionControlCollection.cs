using CitrusDB.Model.Entity;
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
            CancellationToken? token)
            where T : IEntity
        {
            List<Control> controls = new List<Control>();

            await Task.Run(() =>
            {
                //students that was changed in program and store in local
                if (((List<T>)changedEntities).Count == 0)
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
            });

            controls.ForEach(c => controlCollection.Remove(c));
        }

        public static bool IsContaintControl(this ControlCollection controlCollection, int id)
        {
            return controlCollection.Cast<IStudentView>().FirstOrDefault(c => c.GetStudentId == id) != null
                ? true
                : false;
        }
    }
}
