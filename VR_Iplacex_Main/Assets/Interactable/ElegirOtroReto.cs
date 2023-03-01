using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElegirOtroReto : Interactable
{
    ShowTexto activate;
    Evaluando ProgresoEvaluando;
    Tutorial ListaTutorial;
    public override void Interact(){
        base.Interact();
        ProgresoEvaluando =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        ProgresoEvaluando.Reseteo();
        activate = GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();
        activate.MostrarTexto();
        ListaTutorial = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Tutorial>();
        ListaTutorial.CreandoLista();

        
    }
}
