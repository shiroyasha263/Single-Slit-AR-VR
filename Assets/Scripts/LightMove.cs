using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMove : MonoBehaviour
{

    public float speed;
    GameObject FinalLight;
    float offset;

    void Start()
    {
        speed = 0.2f;
        FinalLight = (GameObject)Resources.Load("FinalLight", typeof(GameObject));
        offset = GameObject.FindGameObjectWithTag("SplitWall").GetComponent<Width>().distance / 2 - 5;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        if(transform.position.x > -0.2f)
        {
            Instantiate(FinalLight, new Vector3(0, 0, 30), new Quaternion(0, 0, 1, 1));
            Instantiate(FinalLight, new Vector3(0, offset, 30), new Quaternion(0, 0, 1, 1));
            Instantiate(FinalLight, new Vector3(0, -offset, 30), new Quaternion(0, 0, 1, 1));
            Destroy(gameObject);
        }
    }
}
