using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = System.Random;

public class CellScr : MonoBehaviour
{
    public int state, id, randomNum;
    public Color normCol, partiesCol;

    public static int[] mas = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36,
                 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36,
                 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36,
                 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36};

    void Start()
    {

    }


    public void SetState(int i)
    {
        state = i;
        if (i == 0)
        {
            GetComponent<Image>().color = normCol;
        }

        else if (i == 1)
        {
            GetComponent<Image>().color = partiesCol;

        }
    }


    public static void Shuffle(int[] mas)
    {
       
        Random rand = new Random();

        for (int i = mas.Length - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);

            int tmp = mas[j];
            mas[j] = mas[i];
            mas[i] = tmp;
        }
    }


    public int GetRandom(int curentNum)
    {

        for (int j = curentNum; j < mas.Length; j++)
        {
            randomNum = mas[j];
            return randomNum;
        }

        return randomNum;


    }


}