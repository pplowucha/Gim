using System;
using UnityEngine;
using UnityEngine.UI;

public class MeasureTime : MonoBehaviour
{
    public Text timer;

    private float time;
    private const float timeLimit = 60f;
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timer.text = "Time: " + String.Format("{0:00}", Math.Floor(time));
        if (time >= timeLimit) // Time's up!
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
