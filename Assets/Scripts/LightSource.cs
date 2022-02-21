using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSource : MonoBehaviour
{

    public float delayTime;
    private float delay = 0;
    public float dtime;
    public GameObject InitialLight;

    // Start is called before the first frame update
    void Start()
    {
        delay = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(delay >= delayTime)
        {
            delay = 0;
            newLight();
        }
        else
        {
            delay = delay + dtime;
        }
    }

    void newLight()
    {
        Instantiate(InitialLight, transform.position, Quaternion.identity);
    }
}
