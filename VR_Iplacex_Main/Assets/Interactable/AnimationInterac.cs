using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationInterac : Interactable
{
    ActivarAnimacion ONOFF;
    public override void Interact(){
         
        base.Interact();
        ONOFF = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<ActivarAnimacion>();
        ONOFF.ActivarAnimator();
        
    }
}
