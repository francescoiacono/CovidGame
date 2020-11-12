using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirusBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxInfectionRate(int maxInfection)
    {
        slider.maxValue = maxInfection;
    }

    public void SetInfectionRate(int infection)
    {
        slider.value = infection;
    }



}
