using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Width : MonoBehaviour
{
    public Slider SSWidthLand;
    FringeControl fringeControl;

    [Range(12.8f, 16.8f)]
    public float distance;

    void Start()
    {
        fringeControl = GameObject.Find("FringeController").GetComponent<FringeControl>();
        distance = 12.8f;
        SSWidthLand.value = distance;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.GetChild(0).position = new Vector3(gameObject.transform.GetChild(0).position.x, distance / 2, gameObject.transform.GetChild(0).position.z);
        gameObject.transform.GetChild(1).position = new Vector3(gameObject.transform.GetChild(1).position.x, - distance / 2, gameObject.transform.GetChild(1).position.z);
    }

    private void FixedUpdate()
    {
        SSWidthLand.value = distance;
        SSWidthLand.onValueChanged.AddListener((Width) =>
        {
            distance = Width;
            fringeControl.small_d = Mathf.Lerp(1.5f, 2.5f, (distance - 12.8f) / 4);
        });
    }
}
