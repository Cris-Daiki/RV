using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{
    Evaluando ListaCorrecta,activate;
    public TMP_Text textElement,textElement1;
    ShowTexto activate2;
    float Timer;
    Evaluando JugandoTutorial;
    public GameObject LibroIndicaciones,Tutor,ListaObjetosCorrecta,objetosSeleccionados;
    public GameObject InicioJuego,BotiquinACT,CambiarReto,Body;
    int ActivarElLibro, ContinuarConTutorial;
    string elementosLista;
    // Start is called before the first frame update
    internal bool ActivoTutorial =false;

    public void InicioTutorial(){
        ActivoTutorial = true;
        Tutor.SetActive(true);
        print("ENTRE AL TUTORIAL ");
        ActivarElLibro = 1;
        Timer=0;
        objetosSeleccionados.SetActive(true);
        Body.SetActive(true);
        InicioJuego.SetActive(true);
        BotiquinACT.SetActive(true);
        CambiarReto.SetActive(true);
        
    }


    public void Tutorial2Problemas(){
        activate2 =GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();
        activate2.MostrarTexto();
        print("ME BUGIE?");
        //activate =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        //activate.Jugando();
        
        ListaObjetosCorrecta.SetActive(true);
        CreandoLista();


    //, Environment.NewLine,





    }

    public void CreandoLista(){
        activate =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        activate.Jugando();
        textElement1.text ="";
        ListaCorrecta = FindObjectOfType<Evaluando>();
        textElement.text = "OBJETOS CORRECTOS PARA ESTE PROBLEMA"+"\n";
        for(int i =0; i< ListaCorrecta.OrdenCorrectoDolor.Count;i++){
            textElement1.text += ListaCorrecta.OrdenCorrectoDolor[i].name +"\n";
        }
        
    }












    // Update is called once per frame
    void Update()
    {

        Timer += Time.deltaTime;
        if(ActivarElLibro ==1){
            if(Timer<= 5){
                LibroIndicaciones.SetActive(true);
                
            }else{
                Timer=0;
                ActivarElLibro=2;
            }
        }
        if(ActivarElLibro == 2){
            if(Timer <=5){
                foreach (Transform children in this.LibroIndicaciones.transform){
                    if(children.gameObject.name == "Titulo" || children.gameObject.name == "Contenido 1"){
                        children.gameObject.SetActive(true);
                    }else{
                        children.gameObject.SetActive(false);  
                    }
                }
            }else{
                Timer=0;
                ActivarElLibro=3;
            }
        }
        if(ActivarElLibro == 3){
            if(Timer<= 5){
                foreach (Transform children in this.LibroIndicaciones.transform){
                    if(children.gameObject.name == "Titulo" || children.gameObject.name == "Contenido 2"){
                        children.gameObject.SetActive(true);
                    }else{
                        children.gameObject.SetActive(false);  
                    }
                }
                
            }else{
                foreach (Transform children in this.LibroIndicaciones.transform){
                    if(children.gameObject.name == "Titulo" || children.gameObject.name == "Contenido"){
                        children.gameObject.SetActive(true);
                    }else{
                        children.gameObject.SetActive(false);  
                    }
                }
                LibroIndicaciones.SetActive(false);
                Tutorial2Problemas();
                ActivarElLibro = 0 ;
            }
        }
    }
}
