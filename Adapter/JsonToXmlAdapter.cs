using System.Xml;
using Adapter.Providers;

namespace Adapter;

public class JsonToXmlAdapter : IXmlProvider
{
    private readonly IJsonProvider _jsonDataProvider;

    public JsonToXmlAdapter(IJsonProvider jsonDataProvider)
        => _jsonDataProvider = jsonDataProvider;

    public string GetXmlData(string data)
    {
        var jsonData = _jsonDataProvider.GetJsonData(data);
        
        var xmlDocument = new XmlDocument();
        XmlNode rootNode = xmlDocument.CreateElement("Object");
        xmlDocument.AppendChild(rootNode);

        foreach (var property in jsonData.Properties())
        {
            XmlNode node = xmlDocument.CreateElement(property.Name);
            node.InnerText = property.Value.ToString()!;
            rootNode.AppendChild(node);
        }

        var xmlOutput = xmlDocument.OuterXml;
        return xmlOutput;
    }
}