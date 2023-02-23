using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : Interactable
{
    // Start is called before the first frame update
    AnimationController Apagar;
    internal int apago;
    public override void Interact()
    {
        base.Interact();

        Apagar = GameObject.FindGameObjectWithTag("Animacion").GetComponent<AnimationController>();
        Apagar.call();


    }


}
