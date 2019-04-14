namespace CitrusDB.View.UsersElements.FormLoading
{
  public interface ILoadingForm
  {
    bool isCompleted { get; set; }

    void ShowForm();
    void CloseForm();
  }
}
