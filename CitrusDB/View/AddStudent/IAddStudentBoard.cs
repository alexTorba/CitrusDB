using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB
{
    interface IAddStudentBoard
    {
        string GetFirstName { get; }
        string GetLastName { get; }
        string GetMiddleName { get; }

        string GetCitizenship { get; }
        string GetKnowledgeOfLanguage { get; }

        string DateOfBirth { get; }
        Image GetFirstPhoto { get; }
        Image GetSecondPhoto { get; }

        float GetGrowth { get; }
        float GetWeight { get; }

        event EventHandler SaveButton;
    }
}
