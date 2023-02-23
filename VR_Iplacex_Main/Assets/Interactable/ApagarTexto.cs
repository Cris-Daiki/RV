using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTexto : Interactable
{
    ApagarTextoGeneral Apagar;
    public override void Interact(){
        base.Interact();

        Apagar = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<ApagarTextoGeneral>();
        if(transform.gameObject.name == "Entendido"){
            Apagar.ApagarTextoGenerico(transform.parent.parent.gameObject);
        }else{
            Apagar.ApagarTextoGenerico(transform.gameObject);
        }
        
        
    }
}
