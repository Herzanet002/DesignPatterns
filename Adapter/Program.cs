using Adapter;
using Adapter.Providers;

IJsonProvider jsonDataProvider = new JsonProvider();
IXmlProvider xmlDataProvider = new JsonToXmlAdapter(jsonDataProvider);

var restClient = new RestClient(jsonDataProvider);
var soapClient = new SoapClient(xmlDataProvider);

var restClientResponse = restClient.GetResponseData();
Console.WriteLine($"Json Data from REST Client: {restClientResponse}");
soapClient.SendRequestData(restClientResponse);
var soapClientResponse = soapClient.GetResponse();
Console.WriteLine($"XML Data from SOAP Client: {soapClientResponse}");