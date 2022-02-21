using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleSlit_Slider_controls : MonoBehaviour
{
    public Slider width;
    public Slider distance;

    public void Width_inc()
    {
        width.value += 0.1f;
    }

    public void Width_dec()
    {
        width.value -= 0.1f;
    }

    public void Distance_inc()
    {
        distance.value += 0.1f;
    }

    public void Distance_dec()
    {
        distance.value -= 0.1f;
    }
}
