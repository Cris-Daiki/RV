using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayInteractuable : Interactable
{
    Play activate;

    
    private AnalizarModelo Variable;
    
    public override void Interact(){
         
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("Controlador").GetComponent<Play>();
        activate.Inicio();
        
    }
}
