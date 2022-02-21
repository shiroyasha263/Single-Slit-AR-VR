using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLightMove : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 20f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale = new Vector3(transform.localScale.x + speed, transform.localScale.y + speed, transform.localScale.z);
        if (transform.localScale.x >= 1700)
        {
            Destroy(gameObject);
        }
    }
}
