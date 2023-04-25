using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] 
    private Transform hoursPivot, minutesPivot, secondsPivot;
    private const float HoursToDegrees = -30f, MinutesToDegrees = -6f, SecondsToDegrees = -6f;

    private void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        
        hoursPivot.localRotation = Quaternion.Euler(0, 0, HoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, MinutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, SecondsToDegrees * (float)time.TotalSeconds);
    }
}
