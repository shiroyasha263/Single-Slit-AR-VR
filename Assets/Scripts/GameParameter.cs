using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameParameter : MonoBehaviour
{

    Material finalLight;
    Material initalLight;

    public Color color;
    Color fringeColor;

    GameObject fringe1;
    GameObject fringe2;

    // Start is called before the first frame update
    void Start()
    {
        finalLight = (Material)Resources.Load("FinalMat", typeof(Material));
        initalLight = (Material)Resources.Load("InitialMat", typeof(Material));
        fringe1 = (GameObject)Resources.Load("Fringe1", typeof(GameObject));
        fringe2 = (GameObject)Resources.Load("Fringe2", typeof(GameObject));
        color = initalLight.color;
    }

    // Update is called once per frame
    void Update()
    {
        fringeColor = color;
        fringeColor.a = 1.0f;
        initalLight.color = color;
        fringe1.GetComponent<SpriteRenderer>().color = fringeColor;
        fringe2.GetComponent<SpriteRenderer>().color = fringeColor;
        finalLight.SetColor("Color_e44dc8ada94841b8866abe512b8df0fc", color);
        finalLight.SetVector("Vector3_5d1a7afafb9545d98f07e3bdc8cc2ebb", new Vector3(GameObject.FindGameObjectWithTag("Screen").GetComponent<WallDistance>().distance - 0.2f, 0, 0));
    }
}