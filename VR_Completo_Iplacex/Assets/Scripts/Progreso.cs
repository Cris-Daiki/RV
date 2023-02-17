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
        CirculoCarga.GetComponent<Image>().fillAmount = (Tiempo.timer)/3;
    }
}
