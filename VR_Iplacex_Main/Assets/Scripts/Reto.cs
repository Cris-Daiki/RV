using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reto : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Instrucciones,Vacio,Body,Listo,BotiquinACT,BotonTutorial;
    int contador = 0;

    MostrarProblema ApagarProblema;
    ShowTexto activate;
    public GameObject ONOFFReto;
    public GameObject CambiarReto;
    public GameObject ObjetosElegidosTitulo,BotonTutorialOFF;
    // Update is called once per frame
    public GameObject InicioJuego;
    public void MostrarInstrucciones(){
        activate = GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();
        ApagarProblema = FindObjectOfType<MostrarProblema>();

        if(contador %2 == 0 ){
            Instrucciones.SetActive(true);
            Vacio.SetActive(false);
            //Body.SetActive(false);
            Listo.SetActive(false);
            //ONOFFReto.SetActive(false);
            //activate.ApagarTexto(ApagarProblema.ParteDelCuerpo);
        }else{

            Instrucciones.SetActive(false);
            activate.MostrarTexto();
            Vacio.SetActive(true);
            Body.SetActive(true);
            contador-=1;
            InicioJuego.SetActive(true);
            BotiquinACT.SetActive(true);
            Canvas.SetActive(true);
            Listo.SetActive(true);
            ONOFFReto.SetActive(false);
            CambiarReto.SetActive(true);
            ObjetosElegidosTitulo.SetActive(true);
            
        }
        contador +=1;
    }

    public void TerminarReto(){
        ONOFFReto.SetActive(true);
        Listo.SetActive(false);
        Canvas.SetActive(false);
        CambiarReto.SetActive(false);
        ObjetosElegidosTitulo.SetActive(false);
        BotiquinACT.SetActive(false);
        BotonTutorial.SetActive(true);
    }
    public void TerminarTutorial(){
        Listo.SetActive(false);
        Canvas.SetActive(false);
        CambiarReto.SetActive(false);
        ObjetosElegidosTitulo.SetActive(false);
        BotiquinACT.SetActive(false);
        BotonTutorialOFF.SetActive(false);
        BotonTutorial.SetActive(true);
        ONOFFReto.SetActive(true);

    }

}
