using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    int firstClick;
    //int secondClick;
    //public Color X;

    public void OnClick()
    {
        //GetComponent<Button>().X = new Color(0, 0, 0);
        var A = gameObject.GetComponent(typeof(CellScr)) as CellScr;
        firstClick = A.randomNum;

        Debug.Log("Click1 " + firstClick);
    }

    //public void twoClick()
    //{
    //    var B = gameObject.GetComponent(typeof(CellScr)) as CellScr;
    //    secondClick = B.randomNum;
    //    Debug.Log("Click2 " + secondClick);
    //}
}