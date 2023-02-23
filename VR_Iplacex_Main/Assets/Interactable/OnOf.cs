using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOf : Interactable
{
    ActivarDespliegue ContadorActivarDespliegue;    
    CambioModelo activate;
    //CambiarModeloUnico Activate2,NombreObjetoReferenciado;
    //int contadorPrestado = 0;
    
    private AnalizarModelo Variable;
    
    public override void Interact(){
         
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("CambiarModelo").GetComponent<CambioModelo>();
        activate.whenButtonGeneralClicled();
        
    }
}
