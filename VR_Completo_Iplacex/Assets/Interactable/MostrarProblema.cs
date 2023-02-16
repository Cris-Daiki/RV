using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarProblema : Interactable
{
    internal string ParteDelCuerpo;
    ShowTexto activate;
    int contador = 0;
    public LineRenderer ConeccionFlecha;
    public GameObject ONOFFReto;
    public override void Interact(){
        
        base.Interact();

        ParteDelCuerpo = transform.name;
        activate = GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();

        if(contador == 0){activate.MostrarTexto(ParteDelCuerpo); contador+=1; ConeccionFlecha.enabled = true;ONOFFReto.SetActive(true);}
        else{activate.ApagarTexto(ParteDelCuerpo);contador-=1;ConeccionFlecha.enabled = false;ONOFFReto.SetActive(false);}
    }
}
