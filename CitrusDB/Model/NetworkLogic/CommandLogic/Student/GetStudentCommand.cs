using System.Collections.Generic;
using CitrusDB.Model.NetworkLogic.DtoData;
using CitrusDB.Model.NetworkLogic.DtoData.Respond;

namespace CitrusDB.Model.NetworkLogic.CommandLogic.Student
{
  public class GetStudentRespondDto : RespondDto<List<Entity.Student>>
  {
  }

  public class GetStudentCommand : CommandBase<BaseRequestDto, GetStudentRespondDto>
  {
    public GetStudentCommand(string commandName) : base(commandName)
    {
    }
  }
}