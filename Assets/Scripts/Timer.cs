using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [Header("Индикатор")]
    public Slider mySlider;

    [Header("Осталось времени")]
    public float timeLeft;
    public float gameTime;


    void Update()
    {
        timeLeft = mySlider.maxValue;
        gameTime += (1 * Time.deltaTime)/2;
        if (gameTime >=1)
        {
            mySlider.value++;
            timeLeft ++;
            gameTime = 0;
            if (mySlider.maxValue == mySlider.value)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}