using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    float countdown = 120;
    float time_elapsed;
    float initial_value;

    void Start()
    {
        initial_value = countdown;
    }

    void Update()
    {
        if (countdown > 1)
        {
            countdown -= Time.deltaTime;
            time_elapsed = initial_value - countdown;
        }

        //else if (countdown < 1)
        //{
        //    string message = "DRAW!";
        //}

        float min = Mathf.FloorToInt(countdown / 60);
        float sec = Mathf.FloorToInt(countdown % 60);
        timerText.text = string.Format("{0,00}:{1,00}", min, sec);
        float min_e = Mathf.FloorToInt(time_elapsed / 60);
        float sec_e = Mathf.FloorToInt(time_elapsed % 60);
    }
}
