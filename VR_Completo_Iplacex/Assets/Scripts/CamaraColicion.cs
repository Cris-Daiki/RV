using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraColicion : MonoBehaviour
{
    private float minDistancia = 0;
    private float maxDistancia = 15;
    private float suavidad = 10;
    private float distancia;

    Vector3 direccionColicion;
    private void Start()
    {
        try{
            direccionColicion = transform.localPosition.normalized;
            distancia = transform.localPosition.magnitude;
        }catch{
            print("OCURRIO UN ERROR AL ASIGNAR VALOR A LA VARIABLE: "+direccionColicion+"__"+ distancia);
        }
        
        
    }
    void Update()
    {
        try{
            Vector3 posDeCamara = transform.parent.TransformPoint(direccionColicion*maxDistancia);

            RaycastHit hit;
            if(Physics.Linecast(transform.parent.position, posDeCamara, out hit))
            {
                distancia = Mathf.Clamp(hit.distance *0.85f,minDistancia,maxDistancia);
            }
            else{
                distancia = maxDistancia;
            }
            transform.localPosition = Vector3.Lerp(transform.localPosition, direccionColicion*distancia, suavidad * Time.deltaTime); 
        }catch{
            print("ERROR EN UPDATE CAMARACOLICION");
        }
    }
    


}
