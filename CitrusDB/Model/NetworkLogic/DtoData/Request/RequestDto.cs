using Newtonsoft.Json;

namespace CitrusDB.Model.NetworkLogic.DtoData
{
  public class RequestDto<T> : BaseRequestDto
  {
    [JsonProperty("d")] public T Data;

    public RequestDto()
    {
    }

    public RequestDto(T data, string serverMethod) : base(serverMethod)
    {
      Data = data;
    }
  }
}