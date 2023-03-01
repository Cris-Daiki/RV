using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CerrarInstruccion : MonoBehaviour
{
    float timer;
    public GameObject instruccion, entrar,fondo;
    // Start is called before the first frame update
    void Start()
    {
        instruccion.SetActive(true);
        fondo.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 5 ) 
        {
            fondo.SetActive(false);
            instruccion.SetActive(false);
            entrar.SetActive(true);
        }
    }
}
