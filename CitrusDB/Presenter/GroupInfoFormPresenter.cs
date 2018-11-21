using System;
using System.Linq;
using System.Collections.Generic;

using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model;
using CitrusDB.Model.Entity;
using CitrusDB.View.EntitiesInfo.GroupInfo;
using CitrusDB.Model.Extensions;

namespace CitrusDB.Presenter
{
    class GroupInfoFormPresenter
    {
        readonly IGroupInfoForm groupInfoForm;

        public GroupInfoFormPresenter(IGroupInfoForm groupInfoForm)
        {
            this.groupInfoForm = groupInfoForm;

            this.groupInfoForm.LoadForm += GroupInfoForm_LoadForm;
            this.groupInfoForm.HeaderMouseClick += GroupInfoForm_HeaderMouseClick;
        }

        private void GroupInfoForm_HeaderMouseClick(object sender, HeaderPropertyEventArgs e)
        {
            groupInfoForm.Students = ((ICollection<StudentView>)groupInfoForm.Students)
                                                .OrderBy(e.SelectedHeader)
                                                .ToList();
        }

        private void GroupInfoForm_LoadForm(object sender, EventArgs e)
        {
            var group = EFGenericRepository.FindById<Group>(groupInfoForm.Id);
            groupInfoForm.GroupName = group.Name;
            groupInfoForm.Photo = group.Photo.ConvertByteArrToImage();
            groupInfoForm.Students = group.Students.GetViews<Student, StudentView>().ToList();
        }
    }
}
