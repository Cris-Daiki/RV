using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarObjetosMostrador : MonoBehaviour
{
    public GameObject canvas;
    public List<GameObject> ObjetosMostrador;
    public void MostrarObjetosElegidosMostrador(string Nombre){
        for(int i = 0; i < ObjetosMostrador.Count; i ++){
            if(ObjetosMostrador[i].name == Nombre){
                ObjetosMostrador[i].SetActive(true);
                break;
            }
        }
    }
    public void MostrarCanvas(){
        canvas.SetActive(true);
    }
    public void DesactivarCanvas(){
        canvas.SetActive(true);
    }
    public void DesactivarObjetosMostrador(){
        for(int i =0; i<ObjetosMostrador.Count;i++){
            ObjetosMostrador[i].SetActive(false);
        }
    }
}
