using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Evaluando : MonoBehaviour
{
    //internal List<GameObject> ObjetosElegidosUsuario;
    EligiendoElementos ElementoElegido;
    public List<GameObject> OrdenCorrectoDolorPieDerecho;
    ShowTexto ParteDelCuerpo;
    //int indice;
    public void Jugando(){
        ElementoElegido = FindObjectOfType<EligiendoElementos>();
        ParteDelCuerpo = FindObjectOfType<ShowTexto>();
        //ParteDelCuerpo.NombreParteJuego;
        print("AHORA REVISAREMOS SU RESPUESTA");
        print(ParteDelCuerpo.ParteDelCuerpoElegida );
        if(ParteDelCuerpo.ParteDelCuerpoElegida == "Pie Derecho"){
            if(ElementoElegido.ObjetosElegidos.Count == OrdenCorrectoDolorPieDerecho.Count){
                //for indice,(,) in enumerate(zip())
                /*for item1,item2 in zip(ObjetosElegidosUsuario,OrdenCorrectoDolorPieDerecho):
                    if item1==item2:
                        print("nice")*/
                //bool isEqual =ElementoElegido.ObjetosElegidos.Equals(OrdenCorrectoDolorPieDerecho);
                bool isEqual = ElementoElegido.ObjetosElegidos.ToHashSet().SetEquals(OrdenCorrectoDolorPieDerecho);
                if(isEqual){ 
                    print("nice");
                }else{
                    print("Te equivocaste en el orden u objeto :( ");
                }
            }else{
                print("Lo siento :( tienes objetos de mas o de menos)");
            }
        }
    }
}
