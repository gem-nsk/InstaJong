using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScr : MonoBehaviour
{
    public int cellCount;
    
    public int[] partiesID = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,36,54,72,90,108,126,
        144,162,180,197,198,196,195,194,193,192,191,190,189,188,187,186,185,184,183,182,181,163,145,127,109,91,73,55,37,19};

    public static int[] diceID = {20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,56,57,58,
        59,60,61,62,63,64,65,66,67,68,69,70,71,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,
        110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,146,147,148,149,150,
        151,152,153,154,155,156,157,158,159,160,161,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179};

    
    List<CellScr> AllCells = new List<CellScr>();


    public GameObject cellButton;
    public Transform cellGroup;
    //public GameObject clickButton;


    void Start()
    {
        CreateButtonCells();
        CreateParties();
    }


    public void CreateButtonCells()
    {
        for (int i = 0; i < cellCount; i++)
        {
            GameObject tmpCell = Instantiate(cellButton);
            tmpCell.transform.SetParent(cellGroup, false);
            tmpCell.GetComponent<CellScr>().id = i + 1;
            tmpCell.GetComponent<CellScr>().SetState(0);
            AllCells.Add(tmpCell.GetComponent<CellScr>());
        }
    }


    public void CreateParties()
    {
        CellScr.Shuffle(CellScr.mas);
        for (int i = 0; i < diceID.Length; i++)
        {
            AllCells[diceID[i] - 1].GetRandom(i);
            AllCells[diceID[i] - 1].SetState(1);
            
        }
    }
}