using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FringeControl : MonoBehaviour
{
    public float lamda = 5f;
    float lamdaCheck = 5f;
    public float D = 2f;
    float DCheck = 2f;
    public float small_d = 10f;
    float small_dCheck = 10f;
    public float fringewidth = 0.43f;
    float distCheck = 10.0f;
    public Transform CentreFringePos;
    public Transform LeftEndFringePos;
    public Transform RightFringePos;

    private Vector3 pos;
    int flag = 0;

    public GameObject SideFringes;
    public GameObject MiddleFringe;

    Color MiddleCheck;
    Color SideCheck;

    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(MiddleFringe, CentreFringePos.position , Quaternion.Euler(new Vector3(0, 90, 90)));
        displayfringe();
        MiddleCheck = MiddleFringe.GetComponent<SpriteRenderer>().color;
        SideCheck = SideFringes.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {

        if (lamda != lamdaCheck || D != DCheck || small_d != small_dCheck || GameObject.FindGameObjectWithTag("Screen").GetComponent<WallDistance>().distance != distCheck)
        {
            GameObject[] Fringes = GameObject.FindGameObjectsWithTag("Fringe");
            for (int i = 0; i < Fringes.Length; i++)
            {
                Destroy(Fringes[i]);
            }
            Instantiate(MiddleFringe, CentreFringePos.position, Quaternion.Euler(new Vector3(0, 90, 90)));
            displayfringe();
            lamdaCheck = lamda;
            DCheck = D;
            small_dCheck = small_d;
            distCheck = GameObject.FindGameObjectWithTag("Screen").GetComponent<WallDistance>().distance;
        }
        if (MiddleFringe.GetComponent<SpriteRenderer>().color != MiddleCheck || SideFringes.GetComponent<SpriteRenderer>().color == SideCheck)
        {
            MiddleCheck = MiddleFringe.GetComponent<SpriteRenderer>().color;
            SideCheck = SideFringes.GetComponent<SpriteRenderer>().color;
            GameObject[] Fringes = GameObject.FindGameObjectsWithTag("Fringe");
            for (int i = 0; i < Fringes.Length; i++)
            {
                Destroy(Fringes[i]);
            }
            Instantiate(MiddleFringe, CentreFringePos.position, Quaternion.Euler(new Vector3(0, 90, 90)));
            displayfringe();
        }

    }

    void displayfringe()
    {
        float width = (lamda * D) / small_d;

        pos = CentreFringePos.position;
        pos.y +=width;
        while(pos.y<LeftEndFringePos.position.y)
        {
            
            Instantiate(SideFringes, pos, Quaternion.Euler(new Vector3(0, 90, 90)));
            pos.y +=width;
        }

        pos = CentreFringePos.position;
        pos.y -=width;
        while(pos.y>RightFringePos.position.y)
        {
            
            Instantiate(SideFringes, pos, Quaternion.Euler(new Vector3(0, 90, 90)));
            pos.y -=width;
        }
    }
}
