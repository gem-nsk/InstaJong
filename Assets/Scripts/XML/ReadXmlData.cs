using UnityEngine;
using System.Xml.Linq;
using System.Xml;
using System;


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
        XmlDocument doc = new XmlDocument();
        doc.Load("arrayState0.xml");
        for (int i = 0; i<143;i++)
        {
            try
            {
                int value = Convert.ToInt32(doc.GetElementsByTagName("ID").Item(i).InnerText);
                Debug.Log(value);
            }
            catch
            {
                break;
            }
        }
    }
}
