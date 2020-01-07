using CitrusDB.Model.NetworkLogic.DtoData;
using CitrusDB.Model.NetworkLogic.DtoData.Respond;

namespace CitrusDB.Model.NetworkLogic.CommandLogic
{
  public abstract class CommandBase<T, R> : ICommand<T, R>
    where R : BaseRespondDto
    where T : BaseRequestDto
  {
    public string CommandName { get; }

    protected CommandBase(string commandName)
    {
      CommandName = commandName;
    }

    public R Start(T dto)
    {
      return NetworkManager.Send<T, R>(dto);
    }
  }
}