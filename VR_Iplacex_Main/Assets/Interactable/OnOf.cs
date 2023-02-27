using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  
public class OnOf : Interactable
{
    ActivarDespliegue ContadorActivarDespliegue;    
    CambioModelo activate;
    //CambiarModeloUnico Activate2,NombreObjetoReferenciado;
    //int contadorPrestado = 0;
    public GameObject tapabotiquin;
    string NombreEscena;
    private AnalizarModelo Variable;
    
    public override void Interact(){
         
        base.Interact();

        activate = GameObject.FindGameObjectWithTag("CambiarModelo").GetComponent<CambioModelo>();
        NombreEscena =SceneManager.GetActiveScene().name;
                
            if(NombreEscena == "EscenaBotiquin"){
                print(NombreEscena);
                tapabotiquin.transform.rotation = Quaternion.Euler(272.143463f,-8.65149923e-06f,180f);
                
            }
        activate.whenButtonGeneralClicled();
        
    }
}
