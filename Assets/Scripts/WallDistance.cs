using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallDistance : MonoBehaviour
{
    public Slider SSDistanceLand;
    FringeControl fringeControl;

    [Range(9.0f, 11.0f)]
    public float distance;

    private void Start()
    {
        fringeControl = GameObject.Find("FringeController").GetComponent<FringeControl>();
        distance = 10.0f;
        SSDistanceLand.value = distance;
    }

    void Update()
    {
        transform.position = new Vector3(distance, transform.position.y, transform.position.z);
    }

    private void FixedUpdate()
    {
        SSDistanceLand.onValueChanged.AddListener((Distance) =>
        {
            distance = Distance;
            fringeControl.D = Mathf.Lerp(1.5f, 2.5f, (distance - 9.0f) / 2);
        });
    }
}
