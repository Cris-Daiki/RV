using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio : Interactable
{
    CambiarModelo activate;
    ActivarDespliegue ONOFFROTATE;
    private string nombre;
    public override void Interact(){
         
        
        base.Interact();
        activate = GameObject.FindGameObjectWithTag("CambiarModelo").GetComponent<CambiarModelo>();
        activate.whenButtonClicked();
        
    }
}
