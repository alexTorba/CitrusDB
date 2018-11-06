using CitrusDB.Model.DataBaseLogic;
using CitrusDB.Model.Entity;
using CitrusDB.View.EntitiesInfo.GroupInfo;
using System;

namespace CitrusDB.Presenter
{
    class GroupInfoFormPresenter
    {
        //todo: filling from logic
        readonly IGroupInfoForm groupInfoForm;

        public GroupInfoFormPresenter(IGroupInfoForm groupInfoForm)
        {
            this.groupInfoForm = groupInfoForm;

            this.groupInfoForm.LoadForm += GroupInfoForm_LoadForm;
        }

        private void GroupInfoForm_LoadForm(object sender, EventArgs e)
        {
            var group = EFGenericRepository.FindById<Group>(groupInfoForm.Id);

            groupInfoForm.Name = group.Name;
            groupInfoForm.Photo = group.Photo.ConvertByteArrToImage();
            groupInfoForm.Students = group.Students;
        }
    }
}
