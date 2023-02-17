using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class WinActivacion : MonoBehaviour  
{
    Evaluando evaluando;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        evaluando = FindObjectOfType<Evaluando>();
        if (evaluando.Completado == 1)
        {
            transform.gameObject.SetActive(false);
            time += Time.deltaTime;
            if(time <= 2)
            {
                transform.gameObject.SetActive(false);
            }
        }
        if (evaluando.Completado == 0)
        {
            transform.gameObject.SetActive(false);
        }
    }
}
