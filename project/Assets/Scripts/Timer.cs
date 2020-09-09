using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText; 
    public static bool playing;
    private float Timing;

    void Update()
    {

        if (playing == true)
        {

            Timing += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timing / 60f);
            int seconds = Mathf.FloorToInt(Timing % 60f);
            int milliseconds = Mathf.FloorToInt((Timing * 100f) % 100f);
            TimerText.text = "Time: " + minutes.ToString("00") + ":" + seconds.ToString("00") + ":" +
                             milliseconds.ToString("00");
        }
    }

    void Start()
    {
        playing = true;
    }
}
