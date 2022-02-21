using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{

    GameParameter gameParameter;
    FringeControl fringeControl;

    // Start is called before the first frame update
    void Start()
    {
        gameParameter = GameObject.Find("GameParameter").GetComponent<GameParameter>();
        fringeControl = GameObject.Find("FringeController").GetComponent<FringeControl>();
    }

    // Update is called once per frame
    public void Violet() 
    {
        gameParameter.color = new Color(0.5607f, 0, 1, 0.33f);
        fringeControl.lamda = 3f;
        
    }
    public void Indigo()
    {
        gameParameter.color = new Color(0.2941f, 0, 0.5098f, 0.33f);
        fringeControl.lamda = 3.2f;
    }
    public void Blue()
    {
        gameParameter.color = new Color(0, 0, 1, 0.33f);
        fringeControl.lamda = 3.4f;
    }
    public void Green()
    {
        gameParameter.color = new Color(0, 1, 0, 0.33f);
        fringeControl.lamda = 3.6f;
    }
    public void Yellow()
    {
        gameParameter.color = new Color(1, 0.92f, 0.016f, 0.33f);
        fringeControl.lamda = 3.8f;
    }
    public void Orange()
    {
        gameParameter.color = new Color(1, 0.3592f, 0, 0.33f);
        fringeControl.lamda = 4f;
    }
    public void Red()
    {
        gameParameter.color = new Color(1, 0, 0, 0.33f);
        fringeControl.lamda = 4.2f;
    }
}
