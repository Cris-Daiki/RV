using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTexto : MonoBehaviour
{
    internal string ParteDelCuerpoElegida;
    GameObject OcultarObjeto;
    GameObject ParteEncontrada;
    public void MostrarTexto(string Nombre){
        ParteDelCuerpoElegida =Nombre;
        OcultarObjeto = GameObject.Find("Textos");
        if(Nombre == "Pie Derecho"){ ParteEncontrada = OcultarObjeto.transform.GetChild(0).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Pie Izquierdo"){ ParteEncontrada = OcultarObjeto.transform.GetChild(1).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Mano Derecha"){ ParteEncontrada = OcultarObjeto.transform.GetChild(2).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Mano Izquierda"){ ParteEncontrada = OcultarObjeto.transform.GetChild(3).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Cabeza"){ ParteEncontrada = OcultarObjeto.transform.GetChild(4).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Brazo Derecho"){ ParteEncontrada = OcultarObjeto.transform.GetChild(5).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Brazo Izquierda"){ ParteEncontrada = OcultarObjeto.transform.GetChild(6).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Pecho"){ ParteEncontrada = OcultarObjeto.transform.GetChild(7).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Parte Baja"){ ParteEncontrada = OcultarObjeto.transform.GetChild(8).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Pierna Derecha"){ ParteEncontrada = OcultarObjeto.transform.GetChild(9).gameObject; ParteEncontrada.SetActive(true);}
        if(Nombre == "Pierna Izquierda"){ ParteEncontrada = OcultarObjeto.transform.GetChild(10).gameObject; ParteEncontrada.SetActive(true);}
    } 
    public void ApagarTexto(string Nombre){
        ParteDelCuerpoElegida =Nombre;
        OcultarObjeto = GameObject.Find("Textos");
        if(Nombre == "Pie Derecho"){ParteEncontrada = OcultarObjeto.transform.GetChild(0).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Pie Izquierdo"){ ParteEncontrada = OcultarObjeto.transform.GetChild(1).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Mano Derecha"){ ParteEncontrada = OcultarObjeto.transform.GetChild(2).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Mano Izquierda"){ ParteEncontrada = OcultarObjeto.transform.GetChild(3).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Cabeza"){ ParteEncontrada = OcultarObjeto.transform.GetChild(4).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Brazo Derecho"){ ParteEncontrada = OcultarObjeto.transform.GetChild(5).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Brazo Izquierda"){ ParteEncontrada = OcultarObjeto.transform.GetChild(6).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Pecho"){ ParteEncontrada = OcultarObjeto.transform.GetChild(7).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Parte Baja"){ ParteEncontrada = OcultarObjeto.transform.GetChild(8).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Pierna Derecha"){ ParteEncontrada = OcultarObjeto.transform.GetChild(9).gameObject; ParteEncontrada.SetActive(false);}
        if(Nombre == "Pierna Izquierda"){ ParteEncontrada = OcultarObjeto.transform.GetChild(10).gameObject; ParteEncontrada.SetActive(false);}
    }
}
