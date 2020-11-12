using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerControls : MonoBehaviour
{
    public int MaxTime = 100;
    public VirusBar virusBar;
    private float currentTime;
    private Text t;

    private void Start()
    {
        currentTime = 0f;
        virusBar.SetMaxInfectionRate(MaxTime);
        t = GetComponent<Text>();
    }

    private void Update()
    {
        if (currentTime <= MaxTime)
        {
            currentTime += Time.deltaTime;
            int time = (int)currentTime;
            virusBar.SetInfectionRate(time);
            string textTime = time.ToString();
            t.text = textTime;
        }
    }

}
