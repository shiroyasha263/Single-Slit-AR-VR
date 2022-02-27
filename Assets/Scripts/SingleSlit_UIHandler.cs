using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleSlit_UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] SSMaxUI_Land;
    //[SerializeField] private GameObject[] SSMaxUI_Port;
    [SerializeField] private GameObject SSMinUI;
    [SerializeField] private GameObject[] Color_menu;

    public Toggle SSFine_Land;
    //public Toggle SSFine_Port;
    [SerializeField] private GameObject[] SSFine_bttns;

    // Start is called before the first frame update
    void Start()
    {
        SSMaxUI_Land = GameObject.FindGameObjectsWithTag("Single Slit Landscape UI");
        //SSMaxUI_Port = GameObject.FindGameObjectsWithTag("Single Slit Portrait UI");
        SSMinUI = GameObject.FindGameObjectWithTag("Single Slit Mini UI");
        SSFine_bttns = GameObject.FindGameObjectsWithTag("Single Slit Fine Buttons");
        Color_menu = GameObject.FindGameObjectsWithTag("Color Menu");

        SSFine_Land.isOn = true;
        //SSFine_Port.isOn = true;

        //if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        //{
            SSMaxUI_Land[0].SetActive(true);
            SSMaxUI_Land[1].SetActive(true);
            //SSMaxUI_Port[0].SetActive(false);
            //SSMaxUI_Port[1].SetActive(false);
            SSMinUI.SetActive(false);
        //}
        //else if (Input.deviceOrientation == DeviceOrientation.Portrait)
        //{
        //    SSMaxUI_Land[0].SetActive(false);
        //    SSMaxUI_Land[1].SetActive(false);
        //    SSMaxUI_Port[0].SetActive(true);
        //    SSMaxUI_Port[1].SetActive(true);
        //    SSMinUI.SetActive(false);
        //}

        SSMinUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (SSMinUI.activeSelf != true)
        {
            //if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
            //{
                SSMaxUI_Land[0].SetActive(true);
                SSMaxUI_Land[1].SetActive(true);
                //SSMaxUI_Port[0].SetActive(false);
                //SSMaxUI_Port[1].SetActive(false);
                SSMinUI.SetActive(false);
            //}
            //else if (Input.deviceOrientation == DeviceOrientation.Portrait)
            //{
            //    SSMaxUI_Land[0].SetActive(false);
            //    SSMaxUI_Land[1].SetActive(false);
            //    SSMaxUI_Port[0].SetActive(true);
            //    SSMaxUI_Port[1].SetActive(true);
            //    SSMinUI.SetActive(false);
            //}
        }
    }

    public void SS_Min_Max()
    {
        //if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        //{
        for (int i = 0; i < SSMaxUI_Land.Length; i++)
        {
            SSMaxUI_Land[i].SetActive(!SSMaxUI_Land[i].activeSelf);
        }
        //}

        //else if (Input.deviceOrientation == DeviceOrientation.Portrait)
        //{
        //    for (int i = 0; i < SSMaxUI_Port.Length; i++)
        //    {
        //        SSMaxUI_Port[i].SetActive(!SSMaxUI_Port[i].activeSelf);
        //    }
        //}
        SSMinUI.SetActive(!SSMinUI.activeSelf);
        }

    public void Fine_Controls_Land()
    {
        for (int i = 0; i < SSFine_bttns.Length; i++)
        {
            SSFine_bttns[i].SetActive(SSFine_Land.isOn);
        }

        //SSFine_Port.isOn = SSFine_Land.isOn;
    }

    public void Fine_Controls_Port()
    {
        //for (int i = 0; i < SSFine_bttns.Length; i++)
        //{
        //    SSFine_bttns[i].SetActive(SSFine_Port.isOn);
        //}

        //SSFine_Land.isOn = SSFine_Port.isOn;
    }

    public void Color_Picker()
    {
        for (int i = 0; i < Color_menu.Length; i++)
        {
            Color_menu[i].SetActive(!Color_menu[i].activeSelf);
        }

        Debug.Log("Yeet");
    }
}