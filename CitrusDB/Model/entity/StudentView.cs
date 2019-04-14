namespace CitrusDB.Model.Entity
{
  public class StudentView : IEntity
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }

    public Group Group { get; set; }
  }
}
