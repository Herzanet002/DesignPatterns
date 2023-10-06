using Adapter.Providers;
using Newtonsoft.Json.Linq;

namespace Adapter;

public class RestClient
{
    private readonly IJsonProvider _jsonProvider;
    private readonly HttpClient _httpClient;

    public RestClient(IJsonProvider jsonProvider, HttpClient httpClient)
    {
        _jsonProvider = jsonProvider;
        _httpClient = httpClient;
    }

    public async Task<JObject> GetResponseDataAsync()
    {
        var jsonResponse = await _httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
        return _jsonProvider.GetJsonData(jsonResponse);
    }
}