using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrusDB.View.UsersElements.FormLoading
{
    public interface ILoadingForm
    {
        bool isCompleted { get; set; }

        void ShowForm();
        void CloseForm();
    }
}
