using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarReto : Interactable
{
    Reto activate;
    public override void Interact(){
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Reto>();
        activate.MostrarInstrucciones();
        
    }
    
}
