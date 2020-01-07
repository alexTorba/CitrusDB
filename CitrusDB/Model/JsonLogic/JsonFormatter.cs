using Newtonsoft.Json;

namespace CitrusDB.Model.JsonLogic
{
  public static class JsonFormatter
  {
    private static readonly JsonSerializerSettings _serializerSettings;

    static JsonFormatter()
    {
      _serializerSettings = new JsonSerializerSettings
      {
        NullValueHandling = NullValueHandling.Ignore
      };
    }

    public static string Serialize(object data)
    {
      return JsonConvert.SerializeObject(data, Formatting.None, _serializerSettings);
    }

    public static T Deserialize<T>(string jsonData)
    {
      return JsonConvert.DeserializeObject<T>(jsonData, _serializerSettings);
    }
  }
}