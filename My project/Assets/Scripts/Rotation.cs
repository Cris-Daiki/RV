using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    /*public CambiarModeloUnico NombreDelObjeto;
    static public string Nombre;
    static public Vector3 PosicionDelObjeto;
    int contador = 0;
    float x;
    float y;
    float z ;
    // Update is called once per frame
    public void Start(){
        NombreDelObjeto = FindObjectOfType<CambiarModeloUnico>();
        Nombre = NombreDelObjeto.NombreEncontrado;
        PosicionDelObjeto = NombreDelObjeto.ObjetoReferenciado.transform.rotation;
        if(Nombre== "apositoabsorvente" && contador == 0){
           NombreDelObjeto.ObjetoReferenciado.transform.rotation = Quaternion.Euler(-10,0,0);
            contador +=1;
        }
        
    }*/


    public void Update()
    {       

        
        transform.Rotate(0,0.5f,0);
    }

    
}
