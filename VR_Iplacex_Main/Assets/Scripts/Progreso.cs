using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Progreso : MonoBehaviour
{
    public Transform CirculoCarga;
    CameraInteration Tiempo;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Tiempo = FindObjectOfType<CameraInteration>();
        CirculoCarga.GetComponent<Image>().fillAmount = (Tiempo.timer)/1.5f; //Dividir por la cantidad de segundos que se tiene en camara interatio ej(Tiempo.timer)/3 para que la barra de progreso funcione bien
    }
}
