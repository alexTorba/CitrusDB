using System.Collections.Generic;
using CitrusDB.Model.NetworkLogic.CommandLogic.Student;

namespace CitrusDB.Model.NetworkLogic.CommandLogic
{
  public class CommandFactory
  {
    private static readonly Dictionary<CommandType, string> _commandType = new Dictionary<CommandType, string>
    {
      {CommandType.GetStudent, "CreateStudent"}
    };

    private static readonly List<ICommandObject> _commands = new List<ICommandObject>();

    public static T CreateCommand<T>(CommandType commandType)
    {
      return default;
    }
  }
}