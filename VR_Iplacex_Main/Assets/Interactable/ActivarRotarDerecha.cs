using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarRotarDerecha : Interactable
{
    RotacionModeloDerecha activate;
    int contador =0;
    public override void Interact(){

        base.Interact();
        activate = GameObject.Find("Body_high").GetComponent<RotacionModeloDerecha>();
        if(contador == 0){activate.enabled=true; contador+=1;}
        else{activate.enabled = false;contador-=1;}
    }
}
