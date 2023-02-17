using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInteration : Interactable
{
    PLay activate;

    
    private AnalizarModelo Variable;
    
    public override void Interact(){
         
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("Controlador").GetComponent<PLay>();
        activate.Exit();
        
    }

}
