using CitrusDB.Model.NetworkLogic.DtoData;
using CitrusDB.Model.NetworkLogic.DtoData.Respond;

namespace CitrusDB.Model.NetworkLogic.CommandLogic
{
  public interface ICommand<in T, out R> : ICommandObject
    where T : BaseRequestDto
    where R : BaseRespondDto
  {
    R Start(T dto);
  }
}