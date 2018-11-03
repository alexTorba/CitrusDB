using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CitrusDB.Model.Entity;
namespace CitrusDB.View.EntitiesInfo
{
    interface IStudentInfoForm
    {
        int Id { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string DateOfBirth { get; set; }
        string Height { get; set; }
        string Weight { get; set; }
        string Сitizenship { get; set; }
        string KnowledgeOfLanguage { get; set; }

        Group Group { get; set; }

        Image FirstPhoto { set; }
        Image SecondPhoto { set; }

        event EventHandler FormLoad;
    }
}
