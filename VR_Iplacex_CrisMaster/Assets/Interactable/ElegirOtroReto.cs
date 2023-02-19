using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElegirOtroReto : Interactable
{
    ShowTexto activate;
    Evaluando ProgresoEvaluando;
    public override void Interact(){
        base.Interact();
        ProgresoEvaluando =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        ProgresoEvaluando.Reseteo();
        activate = GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();
        activate.MostrarTexto();
        
    }
}
