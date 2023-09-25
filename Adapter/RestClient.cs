using Adapter.Providers;

namespace Adapter;

public class RestClient
{
    private readonly IJsonProvider _jsonProvider;

    public RestClient(IJsonProvider jsonProvider)
        => _jsonProvider = jsonProvider;

    public string GetResponseData()
    {
        var jsonData = "{\"name\":\"John\",\"age\":30,\"city\":\"New York\"}";
        return _jsonProvider.GetJsonData(jsonData);
    }
}