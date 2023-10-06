using Newtonsoft.Json.Linq;

namespace Adapter.Providers;

public class JsonProvider : IJsonProvider
{
    public JObject GetJsonData(string data) 
        => JObject.Parse(data);
}