using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Invisible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var renders = GetComponentsInChildren<Renderer>();
        foreach (Renderer rendr in renders)
        {
            rendr.material.renderQueue = 2002;
        }

    }

}
