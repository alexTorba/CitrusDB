using Newtonsoft.Json;

namespace CitrusDB.Model.NetworkLogic.DtoData.Respond
{
  public class BaseRespondDto
  {
    [JsonProperty("s")] public int StatusCode;
  }
}