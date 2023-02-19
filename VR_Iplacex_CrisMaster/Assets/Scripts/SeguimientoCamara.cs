using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform modelo;
    public Transform Camara;
    public Vector3 camOffset;   //obtener direccion
    public Vector3 translation = new Vector3(0, 0, -1);
    [Range(0.1f, 1.0f)]
    public float SmoothFactor = 0.1f;  //suabidad del movimiento cam

    public bool rotacionActive;
    public float velRotation = 20.0f;
    public bool lookModel = false;
    
    

    void Start ()
    {
        
        camOffset = Camara.position - transform.position /*-translation*/;

    }
    void FixedUpdate() //actuallizar a cada cuadro
    {

        
        if(rotacionActive)
        {//obtener el angulo de rotacion de la camara 
            //Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X")* velRotation, Vector3.up);

            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * velRotation, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * velRotation, Vector3.right);
            camOffset = camTurnAngle * camOffset;
        }
        Vector3 newPos = modelo.position + camOffset;  //obtener siempre la posi del modelo

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor); 


        if(lookModel || rotacionActive){
            transform.LookAt(modelo);
        }
        if(Input.GetButton("Fire1"))
        {
            rotacionActive= true;
        }
        else
        {
            rotacionActive=false;
            transform.LookAt(modelo);
        }
    }
}
