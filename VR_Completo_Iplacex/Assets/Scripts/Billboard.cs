using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera Camara;

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camara.transform.forward;
    }
}
