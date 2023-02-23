using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CambiarModelo : MonoBehaviour
{
    internal CambiarModeloUnico NombreDelObjeto;
    private CambiarModeloUnico OnOfRotation;
    private int contadorPrestado = 0;
    private string Nombre;
    internal int contadorCambioModelo = 0;
    GameObject ObjetoIdentificado;
    Vector3 PosicionOriginal;
    CambiarModeloUnico activate;
    int contadorModelo = 0;
    ChangeColor ActivarCambioColor;
    internal int contadorFuncional = 0;

    int contadorprueba=0;
    public void whenButtonClicked()
    {
        ActivarCambioColor = GameObject.FindGameObjectWithTag("CambiarModelo").GetComponent<ChangeColor>();
        ActivarCambioColor.ChangeColorButton1press();


        NombreDelObjeto = FindObjectOfType<CambiarModeloUnico>();
        Nombre = NombreDelObjeto.NombreEncontrado;
        contadorPrestado = NombreDelObjeto.contador;
        try
        {
            if (contadorPrestado % 2 != 0)
            {
                OnOfRotation = GameObject.FindGameObjectWithTag("Analis").GetComponent<CambiarModeloUnico>();
                OnOfRotation.UpdateRotation(Nombre);    
                contadorprueba+=1;

            }

        }
        catch
        {
            print("Necesita Inspeccionar Un objeto Primero");
        }

    }




    Despliegue ContadorScriptDespliegue;
    
    CambiarModeloUnico activateVolver;
    public void whenButtonGeneralClicled()
    {
        ActivarCambioColor = GameObject.FindGameObjectWithTag("CambiarModelo").GetComponent<ChangeColor>();
        ActivarCambioColor.ChangeColorButton2press();
        try
        {   
            ContadorScriptDespliegue = FindObjectOfType<Despliegue>();
            
            NombreDelObjeto = FindObjectOfType<CambiarModeloUnico>();
            ObjetoIdentificado = NombreDelObjeto.ObjetoReferenciado;

            contadorModelo = NombreDelObjeto.contador;



            if(((NombreDelObjeto.contador % 2) == 0) && ContadorScriptDespliegue.contadorDespliegue == 1){

                activateVolver = GameObject.FindGameObjectWithTag("Analis").GetComponent<CambiarModeloUnico>();
                activateVolver.Update3();
                ContadorScriptDespliegue.contadorDespliegue = ContadorScriptDespliegue.contadorDespliegue -1;
            }


            if(((NombreDelObjeto.contador % 2) != 0) && ContadorScriptDespliegue.contadorDespliegue == 2){

                ObjetoIdentificado.layer = 6;
                foreach (Transform children in this.ObjetoIdentificado.transform){
                    children.gameObject.layer =6;
                }
                if ((contadorCambioModelo % 2) != 0)
                {
                    NombreDelObjeto.contadorRotation += 1;
                    contadorCambioModelo += 1;
                }
                if(contadorprueba != 0){
                    NombreDelObjeto.contadorRotation = 1;
                }
                ContadorScriptDespliegue.contadorDespliegue = ContadorScriptDespliegue.contadorDespliegue -1;
                activateVolver = GameObject.FindGameObjectWithTag("Analis").GetComponent<CambiarModeloUnico>();
                activateVolver.WhenUserSee(ObjetoIdentificado.name);
            }
        
        }
        catch
        {
            print("Favor de seguir los pasos indicados !!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }
}
