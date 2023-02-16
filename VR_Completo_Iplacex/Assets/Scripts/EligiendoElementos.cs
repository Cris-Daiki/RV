using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EligiendoElementos : MonoBehaviour
{
    //cambiar a internal una vez terminen las pruebas
    public List<GameObject> ObjetosElegidos;
    public void ElementosElegidos(GameObject ObjetoElegido){
        ObjetosElegidos.Add(ObjetoElegido);
    }
}
