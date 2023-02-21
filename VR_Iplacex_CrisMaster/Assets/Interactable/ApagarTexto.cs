using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTexto : Interactable
{
    ApagarTextoGeneral Apagar;
    public override void Interact(){
        base.Interact();

        Apagar = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<ApagarTextoGeneral>();
        Apagar.ApagarTextoGenerico(transform.gameObject);
        
    }
}
