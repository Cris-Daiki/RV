using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroscopioMenu : MonoBehaviour
{
    [SerializeField]
    public GameObject VRCamaras;
    private float PositionInicialY = 0f;
    private float PositionGyroY=0f;
    private float CalibrarPositionY =0f;
    public bool Inicio;


    void Start()
    {
        Input.gyro.enabled = true;
        PositionInicialY = VRCamaras.transform.eulerAngles.y;
    }
    void Update()
    {   
        //print(Input.acceleration.x +","+Input.acceleration.y+","+Input.acceleration.z);
        AplicarRotacionGyro();
        AplicarCalibracion();
        if(Inicio == true)
        {
            Invoke("CalibrarEnPositionY", 1f);
            Inicio = false;
        }
        
    }
    void AplicarRotacionGyro()
    {
        VRCamaras.transform.rotation = Input.gyro.attitude;
        VRCamaras.transform.Rotate(0f,0f,180f, Space.Self);
        VRCamaras.transform.Rotate(90f,180f,0f, Space.World);
        PositionGyroY = VRCamaras.transform.eulerAngles.y;
        //transform.Rotate(new Vector3(Input.acceleration.y, Input.acceleration.x,0)*Time.deltaTime*VelocidadAngular);

    }
    void CalibrarEnPositionY()
    {
        CalibrarPositionY = PositionGyroY-PositionInicialY;
        
    }
    void AplicarCalibracion(){
        VRCamaras.transform.Rotate(0f,-CalibrarPositionY,0f,Space.World);
    }
}