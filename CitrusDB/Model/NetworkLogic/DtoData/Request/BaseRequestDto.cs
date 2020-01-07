using Newtonsoft.Json;

namespace CitrusDB.Model.NetworkLogic.DtoData
{
  public class BaseRequestDto
  {
    [JsonProperty("s")] public string ServerMethod;

    public BaseRequestDto()
    {
    }

    public BaseRequestDto(string serverMethod)
    {
      ServerMethod = serverMethod;
    }
  }
}