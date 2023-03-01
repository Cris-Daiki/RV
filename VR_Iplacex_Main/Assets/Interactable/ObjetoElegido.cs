using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoElegido : Interactable{
    EligiendoElementos activate;
    Evaluando activate2;
    public override void Interact(){
        base.Interact();

        
        activate = GameObject.FindGameObjectWithTag("ObtenerElemento").GetComponent<EligiendoElementos>();
        activate.ElementosElegidos(transform.root.gameObject);
        transform.root.gameObject.SetActive(false);
        activate2 = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        activate2.Jugando();
        
        
    }
}
