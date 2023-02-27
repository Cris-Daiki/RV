using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarProblema : Interactable
{
    ShowTexto activate;
    int contador = 0;
    //public LineRenderer ConeccionFlecha;
    public override void Interact(){
        
        base.Interact();
        activate = GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();
        if(contador == 0){activate.MostrarTexto(); contador+=1; /*ConeccionFlecha.enabled = true;*/}
        else{activate.ApagarTexto();contador-=1;/*ConeccionFlecha.enabled = false;*/}
    }
}
