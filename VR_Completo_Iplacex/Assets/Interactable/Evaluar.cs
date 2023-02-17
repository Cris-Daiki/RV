using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluar : Interactable
{
    Evaluando activate;
    

    public override void Interact(){
        base.Interact();
        activate = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        activate.Jugando();
        
    }
}
