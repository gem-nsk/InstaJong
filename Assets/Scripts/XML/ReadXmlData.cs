﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;



public class DataCellButton
{

    public List<int> diceID1 ;


}


public class ReadXmlData : MonoBehaviour 
{
    private void Start()
    {
        
    }

    

    public void SaveArray(int idElem)
    {
        DataCellButton knight = new DataCellButton();

        knight.diceID1 = new List<int> {20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,56,57,58,
        59,60,61,62,63,64,65,66,67,68,69,70,71,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,
        110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,146,147,148,149,150,
        151,152,153,154,155,156,157,158,159,160,161,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179};
        knight.diceID1.Add(idElem);

        XMLOp.Serialize(knight, "arrayState0.xml");

    }

}