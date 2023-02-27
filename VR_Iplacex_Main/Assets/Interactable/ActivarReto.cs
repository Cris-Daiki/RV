using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarReto : Interactable
{
    Reto activate; 
    public GameObject Tutorial,botonTutorial,SalirTutorial,BotonReto,Canvas,ObjetoQContieneLaAnimacion;
    public BoxCollider BoxColliderTapa,BoxColliderBase;
    Tutorial activate2;
    

    public override void Interact(){
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Reto>();
        if(transform.gameObject.name == "ActivarTutorial"){
            foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                children.gameObject.layer =6;
            }
            BoxColliderTapa.enabled = true;
            BoxColliderBase.enabled = true;
            transform.gameObject.SetActive(false);
            Tutorial.SetActive(true);
            SalirTutorial.SetActive(true);
            BotonReto.SetActive(false);                                                                                                             
        }else{
            if(transform.root.gameObject.name == "TextoTutorial"){
                foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                    children.gameObject.layer =6;
                }
                BoxColliderTapa.enabled = true;
                BoxColliderBase.enabled = true;
                transform.root.gameObject.SetActive(false);
                Canvas.SetActive(true);
                activate2 =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Tutorial>();
                activate2.InicioTutorial();
            }else{
                foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                    children.gameObject.layer =6;
                }
                BoxColliderTapa.enabled = true;
                BoxColliderBase.enabled = true;
                activate.MostrarInstrucciones();
                botonTutorial.SetActive(false);
            }
            
        }
        
    }
    
}
