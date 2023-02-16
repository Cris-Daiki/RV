using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoElegido : Interactable{
    EligiendoElementos activate;
    public override void Interact(){
        base.Interact();
        print("hola");
        activate = GameObject.FindGameObjectWithTag("ObtenerElemento").GetComponent<EligiendoElementos>();
        activate.ElementosElegidos(transform.root.gameObject);
        transform.root.gameObject.SetActive(false);
        
    }
}
