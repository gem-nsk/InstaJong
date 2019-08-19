using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour

{
    int firstClick;
    int secondClick;
    public static int r;
    public Image panel;
    public static int x;
    public static int y;
    public static int idx;
    public static int idy;

    void Start()
    {
        panel = GetComponent<Image>();
    }

    void Update()
    {
        Reset();
        Delete();
    }


    

    public int Reset()
    {
        if (x != y)
        {

            //if (panel.color == Color.cyan)
            //{
            //    panel.color = Color.white;
            //    //Debug.Log("C333333333 ");
            //}
        }

        return 9;
    }

    public int Delete()
    {
        var C = gameObject.GetComponent(typeof(CellScr)) as CellScr;

        if (x == y && idx != idy)
        {
            if (x == firstClick)
            {
                var P = gameObject.GetComponent(typeof(ReadXmlData)) as ReadXmlData; 
                P.SaveArray(idx); 
                var Z = gameObject.GetComponent(typeof(ReadXmlData)) as ReadXmlData;
                Z.SaveArray(idy);
                panel.color = Color.white * 0.0f;
                C.state = 0;
               
            }
        }

        return 5;
    }


    public void Foo()
    {

        if (r == 0)
        {
            
            var A = gameObject.GetComponent(typeof(CellScr)) as CellScr;
            firstClick = A.randomNum;
            x = firstClick;
            Debug.Log("Click1 " + firstClick);
            var V = gameObject.GetComponent(typeof(CellScr)) as CellScr;
            idx = V.id;
            r++;
        }
        else if (firstClick == 0 && r == 1)
        {
            
            var B = gameObject.GetComponent(typeof(CellScr)) as CellScr;
            secondClick = B.randomNum;
            y = secondClick;
            var M = gameObject.GetComponent(typeof(CellScr)) as CellScr;
            idy = M.id;
            
            Debug.Log("Click2 " + secondClick);
            if (x == y && idx != idy)
            {
                
                panel.color = Color.white * 0.0f;
                var C = gameObject.GetComponent(typeof(CellScr)) as CellScr;
                C.state = 0;
                if (firstClick == x)
                {
                    panel.color = Color.white * 0.0f;
                    C.state = 0;
                    
                  
                }
            }
          
            r--;
        }
    }


    public void OnClick()
    {
        Foo();

    }
}