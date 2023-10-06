using Newtonsoft.Json.Linq;

namespace Adapter.Providers;

public interface IJsonProvider
{
    JObject GetJsonData(string data);
}