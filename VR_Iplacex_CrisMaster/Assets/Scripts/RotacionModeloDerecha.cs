using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionModeloDerecha : MonoBehaviour
{
    public void Update()
    {       
        transform.Rotate(0,0,-0.5f);
    }
}
