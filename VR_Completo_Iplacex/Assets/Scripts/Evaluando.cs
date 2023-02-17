
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMpro;
using System.Linq;

public class Evaluando : MonoBehaviour
{
    public UnityEngine.UI.Image BarraCarga;
    //internal List<GameObject> ObjetosElegidosUsuario;
    EligiendoElementos ElementoElegido;
    public List<GameObject> OrdenCorrectoDolor;
    public List<GameObject> OrdenCorrectoDolorPieDerecho;
    public List<GameObject> OrdenCorrectoDolorPieIzquierda;
    public List<GameObject> OrdenCorrectoDolorManoDerecha;
    public List<GameObject> OrdenCorrectoDolorManoIzquierda;
    public List<GameObject> OrdenCorrectoDolorCabeza;
    public List<GameObject> OrdenCorrectoDolorBrazoDerecho;
    public List<GameObject> OrdenCorrectoDolorBrazoIzquierda;
    public List<GameObject> OrdenCorrectoDolorPecho;
    public List<GameObject> OrdenCorrectoDolorParteBaja;
    public List<GameObject> OrdenCorrectoDolorPiernaDerecha;
    public List<GameObject> OrdenCorrectoDolorPiernaIzquierda;

    ShowTexto ParteDelCuerpo;
    public List<GameObject> ObjetosJuego;
    int indice;
    float progreso=0f;
    int ActivarFixedUpdate;
    string ProblemaCuerpo;
    internal int Completado = 0;
    //public TMpro.TextMeshProUGUI Porcentaje;
    public void Jugando(){
        ElementoElegido = FindObjectOfType<EligiendoElementos>();
        ParteDelCuerpo = FindObjectOfType<ShowTexto>();
        ProblemaCuerpo = ParteDelCuerpo.ParteDelCuerpoElegida;

        if(ProblemaCuerpo != "Null"){
            switch(ParteDelCuerpo.ParteDelCuerpoElegida)
            {
                case "Pie Derecho":
                    OrdenCorrectoDolor = OrdenCorrectoDolorPieDerecho;
                    break;
                case "Pie Izquierdo":
                    OrdenCorrectoDolor = OrdenCorrectoDolorPieIzquierda;
                    break;
                case "Mano Derecha":
                    OrdenCorrectoDolor = OrdenCorrectoDolorManoDerecha;
                    break;
                case "Mano Izquierda":
                    OrdenCorrectoDolor = OrdenCorrectoDolorManoIzquierda;
                    break;
                case "Cabeza":
                    OrdenCorrectoDolor = OrdenCorrectoDolorCabeza;
                    break;
                case "Brazo Derecho":
                    OrdenCorrectoDolor = OrdenCorrectoDolorBrazoDerecho;
                    break;
                case "Brazo Izquierda":
                    OrdenCorrectoDolor = OrdenCorrectoDolorBrazoIzquierda;
                    break;
                case "Pecho":
                    OrdenCorrectoDolor = OrdenCorrectoDolorPecho;
                    break;
                case "Parte Baja":
                    OrdenCorrectoDolor = OrdenCorrectoDolorParteBaja;
                    break;
                case "Pierna Derecha":
                    OrdenCorrectoDolor = OrdenCorrectoDolorPiernaDerecha;
                    break;
                case "Pierna Izquierda":
                    OrdenCorrectoDolor = OrdenCorrectoDolorPiernaIzquierda;
                    break;
            }

        }
        if(ElementoElegido.ObjetosElegidos.Count == OrdenCorrectoDolor.Count){
            bool isEqual = ElementoElegido.ObjetosElegidos.ToHashSet().SetEquals(OrdenCorrectoDolor);
            if(isEqual){ //completamos
                progreso = ((float)ElementoElegido.ObjetosElegidos.Count/OrdenCorrectoDolor.Count);
                ActivarFixedUpdate+=1;
                Completado = 1;
                //hacer funcion que elimine este problema y que vuelva todo a lo original 
            }else{
                progreso = 0f;
                ActivarFixedUpdate+=1;
                for(int x = 0; x<ObjetosJuego.Count; x++){
                    ObjetosJuego[x].SetActive(true);
                }
                ElementoElegido.ObjetosElegidos.Clear();
            }
        }else{
            indice = ElementoElegido.ObjetosElegidos.Count;
            for (int i=0; i<indice; i++){
                if(ElementoElegido.ObjetosElegidos[i] == OrdenCorrectoDolor[i]){
                    progreso = ((float)ElementoElegido.ObjetosElegidos.Count/OrdenCorrectoDolor.Count);
                }else{
                    for(int x = 0; x<ObjetosJuego.Count; x++){
                        ObjetosJuego[x].SetActive(true);
                    }
                    progreso =0f;
                    ElementoElegido.ObjetosElegidos.Clear();
                    break;
                }
            }
            ActivarFixedUpdate+=1;
        }
    }
    private void FixedUpdate(){
        if(ActivarFixedUpdate != 0){
            BarraCarga.fillAmount= Mathf.Lerp(BarraCarga.fillAmount, progreso, .05f);
        }
    }
}
