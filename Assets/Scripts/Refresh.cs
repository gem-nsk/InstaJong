using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Configuration;

public class Refresh : MonoBehaviour
{
    
    void Start()
    {
       
    }

   
    void Update()
    {
        
    }

    public void PressRefresh()
    {
        var B = gameObject.GetComponent(typeof(CellScr)) as CellScr;
        var randomNum = B.randomNum;

        for (int i = 0; i < 199; i++)
        {

        }
        

    }

}
