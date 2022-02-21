using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SingleSlit_UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject[] SSMaxUI_Land;
    [SerializeField] private GameObject[] SSMaxUI_Port;
    [SerializeField] private GameObject SSMinUI;

    public Toggle SSFine_Land;
    public Toggle SSFine_Port;
    [SerializeField] private GameObject[] SSFine_bttns;

    // Start is called before the first frame update
    void Start()
    {
        SSMaxUI_Land = GameObject.FindGameObjectsWithTag("Single Slit Landscape UI");
        SSMaxUI_Port = GameObject.FindGameObjectsWithTag("Single Slit Portrait UI");
        SSMinUI = GameObject.FindGameObjectWithTag("Single Slit Mini UI");
        SSFine_bttns = GameObject.FindGameObjectsWithTag("Single Slit Fine Buttons");

        SSFine_Land.isOn = true;
        SSFine_Port.isOn = true;
        
        for(int i = 0; i < SSFine_bttns.Length; i++)
        {
            SSFine_bttns[i].SetActive(true);
        }
        for (int i = 0; i < SSMaxUI_Port.Length; i++)
        {
            SSMaxUI_Port[i].SetActive(false);
        }

        SSMinUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SS_Min_Max()
    {
        for (int i = 0; i < SSMaxUI_Land.Length; i++)
        {
            SSMaxUI_Land[i].SetActive(!SSMaxUI_Land[i].activeSelf);
        }

        SSMinUI.SetActive(!SSMinUI.activeSelf);
    }

    public void Fine_Controls()
    {
        for (int i = 0; i < SSFine_bttns.Length; i++)
        {
            SSFine_bttns[i].SetActive(SSFine_Land.isOn);
        }
    }
}
