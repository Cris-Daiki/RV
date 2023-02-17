using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElegirOtroReto : Interactable
{
    ShowTexto activate;
    public override void Interact(){
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();
        activate.MostrarTexto();
        
    }
}
