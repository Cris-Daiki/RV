using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarReto : Interactable
{
    Reto activate; 
    public GameObject Tutorial,botonTutorial,SalirTutorial,BotonReto,Canvas;
    Tutorial activate2;
    

    public override void Interact(){
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Reto>();
        if(transform.gameObject.name == "ActivarTutorial"){
            transform.gameObject.SetActive(false);
            Tutorial.SetActive(true);
            SalirTutorial.SetActive(true);
            BotonReto.SetActive(false);
        }else{
            if(transform.root.gameObject.name == "TextoTutorial"){
                transform.root.gameObject.SetActive(false);
                Canvas.SetActive(true);
                activate2 =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Tutorial>();
                activate2.InicioTutorial();
            }else{
                activate.MostrarInstrucciones();
                botonTutorial.SetActive(false);
            }
            
        }
        
    }
    
}
