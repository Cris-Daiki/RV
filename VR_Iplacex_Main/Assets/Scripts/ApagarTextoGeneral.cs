using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTextoGeneral : MonoBehaviour
{
    public void ApagarTextoGenerico(GameObject TextoSeleccionado){
        try{
            TextoSeleccionado.gameObject.SetActive(false);
        }catch{
            print("No se asigno un texto el cual Apagar.");
        }
    }
}
