using Newtonsoft.Json;

namespace CitrusDB.Model.NetworkLogic.DtoData.Respond
{
  public class RespondDto<T> : BaseRespondDto
  {
    [JsonProperty("d")] public T Data;
  }
}