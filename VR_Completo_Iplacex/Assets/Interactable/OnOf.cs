using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOf : Interactable
{
    ActivarDespliegue ContadorActivarDespliegue;    
    CambiarModelo activate;
    //CambiarModeloUnico Activate2,NombreObjetoReferenciado;
    //int contadorPrestado = 0;
    
    private AnalizarModelo Variable;
    
    public override void Interact(){
         
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("CambiarModelo").GetComponent<CambiarModelo>();
        activate.whenButtonGeneralClicled();
        
    }
}
