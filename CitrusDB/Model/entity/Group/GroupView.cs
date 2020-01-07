namespace CitrusDB.Model.Entity
{
  public class GroupView : IEntity
  {
    public int Id { get; set; }
    public byte[] Photo { get; set; }
    public string Name { get; set; }
    public int Students { get; set; }
  }
}
