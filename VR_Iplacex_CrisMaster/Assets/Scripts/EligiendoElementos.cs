using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EligiendoElementos : MonoBehaviour
{
    private MostrarObjetosMostrador EnviarObjetoAMostrador;
    //cambiar a internal una vez terminen las pruebas
    public List<GameObject> ObjetosElegidos;
    public void ElementosElegidos(GameObject ObjetoElegido){
        EnviarObjetoAMostrador =GameObject.FindGameObjectWithTag("MostradorObjetos").GetComponent<MostrarObjetosMostrador>();
        ObjetosElegidos.Add(ObjetoElegido);
        EnviarObjetoAMostrador.MostrarObjetosElegidosMostrador(ObjetoElegido.name);
    }
}
