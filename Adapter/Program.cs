using Adapter;
using Adapter.Providers;


IJsonProvider jsonDataProvider = new JsonProvider();
IXmlProvider xmlDataProvider = new JsonToXmlAdapter(jsonDataProvider);

var httpClient = new HttpClient();
await Client(jsonDataProvider, xmlDataProvider, httpClient);
return;

async Task Client(IJsonProvider jsonProvider, IXmlProvider xmlProvider, HttpClient client)
{
    var restClient = new RestClient(jsonProvider, client);
    var soapClient = new SoapClient(xmlProvider);

    var responseJObject = await restClient.GetResponseDataAsync();
    var restClientResponse = responseJObject.ToString()!;

    soapClient.SendRequestData(restClientResponse);
    var soapClientResponse = soapClient.GetResponse();

    Console.WriteLine($"Json Data from REST Client: {restClientResponse}");
    Console.WriteLine(new string('-', 80));
    Console.WriteLine($"XML Data to SOAP Client: {soapClientResponse}");
}