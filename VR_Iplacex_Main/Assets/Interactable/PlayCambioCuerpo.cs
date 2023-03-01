using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCambioCuerpo : Interactable
{

    PlayInspeccionarcuerpo activate;


    private AnalizarModelo Variable;

    public override void Interact()
    {

        base.Interact();
        activate = GameObject.FindGameObjectWithTag("Controlador").GetComponent<PlayInspeccionarcuerpo>();
        activate.Inicio();

    }
}