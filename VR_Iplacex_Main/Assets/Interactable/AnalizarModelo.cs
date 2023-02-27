using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalizarModelo : Interactable
{
    CambiarModeloUnico activate;

    public string NombrePadre;

     //al hacer esto se inicializan todos los objetos con este componente poniendo  a la variable con constantes actualizaciones
    
    public override void Interact(){
        try{
            NombrePadre = transform.parent.name;
        }catch{
            print("Error al asignar valor a la variable, revisar null");
        }
        
        try{
            base.Interact();
            activate = GameObject.FindGameObjectWithTag("Analis").GetComponent<CambiarModeloUnico>();
            activate.WhenUserSee(NombrePadre);
        }catch{
            print("Error se desconoce la variable, asegurese de seguir los pasos asignados para la correcta funcion del programa");
        }
        




    }
}
