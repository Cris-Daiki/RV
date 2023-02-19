using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletasteElReto : Interactable
{
    Evaluando activate;
    ShowTexto activate2;
    Reto activate3;
    Evaluando ProgresoEvaluando;
    public override void Interact(){
        base.Interact();
        ProgresoEvaluando =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        ProgresoEvaluando.Reseteo();
        activate = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        activate.CompletoReto();
        activate2 =GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();
        activate2.ApagarTexto();
        activate3 =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Reto>();
        activate3.TerminarReto();

    }
}
