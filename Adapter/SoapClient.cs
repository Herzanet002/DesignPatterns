using Adapter.Providers;

namespace Adapter;

public class SoapClient
{
    private readonly IXmlProvider _xmlProvider;
    private string? Response { get; set; }

    public SoapClient(IXmlProvider xmlProvider)
        => _xmlProvider = xmlProvider;

    public void SendRequestData(string xmlData)
        => Response = _xmlProvider.GetXmlData(xmlData);

    public string? GetResponse() => Response;
}