using UnityEngine;
using System.Xml.Linq;


public class ReadXmlData : MonoBehaviour 
{
    private void Start()
    {
        
    }





    public void SaveArray(int idElem)
    {
        XDocument doc = XDocument.Load("arrayState0.xml");
        doc.Root.Add(new XElement("ID", idElem));
        doc.Save("arrayState0.xml");
    }

    public void ReadArray()
    {
        string fileName = "arrayState0.xml";
        XDocument doc = XDocument.Load(fileName);
        var z = doc.Elements("ID");
        Debug.Log(z);
    }

}
