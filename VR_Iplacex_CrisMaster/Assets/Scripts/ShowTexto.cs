using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTexto : MonoBehaviour
{
    internal string ParteDelCuerpoElegida;
    GameObject OcultarObjeto;
    GameObject ParteEncontrada;
    internal string ParteDelCuerpo;
    public List<GameObject> ObjetoFind;
    internal int NumeroAleatorio;
    public LineRenderer Linea;
    internal GameObject Objeto;
    int contador;
    ShowMision Mision;
    public GameObject MensajeCompletado;

    public void MostrarTexto()
    {
        Mision = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<ShowMision>();

        MensajeCompletado.SetActive(false);
        contador += 1;
        if (contador > 1)
        {
            ApagarTexto();
        }
        NumeroAleatorio = Random.Range(0, 7);
        print(NumeroAleatorio);
        ParteDelCuerpo = ElegirCaso(NumeroAleatorio);

        ParteDelCuerpoElegida = ParteDelCuerpo;
        for (int i = 0; i < ObjetoFind.Count; i++)
        {
            if (ObjetoFind[i].name == ParteDelCuerpo)
            {
                Objeto = ObjetoFind[i];
                break;
            }
        }
        Mision.Call();

        OcultarObjeto = GameObject.Find("Textos");
        if (ParteDelCuerpo == "Pie Derecho") { ParteEncontrada = OcultarObjeto.transform.GetChild(0).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Pie Izquierdo") { ParteEncontrada = OcultarObjeto.transform.GetChild(1).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Mano Derecha") { ParteEncontrada = OcultarObjeto.transform.GetChild(2).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Mano Izquierda") { ParteEncontrada = OcultarObjeto.transform.GetChild(3).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Cabeza") { ParteEncontrada = OcultarObjeto.transform.GetChild(4).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Brazo Derecho") { ParteEncontrada = OcultarObjeto.transform.GetChild(5).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Brazo Izquierda") { ParteEncontrada = OcultarObjeto.transform.GetChild(6).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Pecho") { ParteEncontrada = OcultarObjeto.transform.GetChild(7).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Parte Baja") { ParteEncontrada = OcultarObjeto.transform.GetChild(8).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Pierna Derecha") { ParteEncontrada = OcultarObjeto.transform.GetChild(9).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Pierna Izquierda") { ParteEncontrada = OcultarObjeto.transform.GetChild(10).gameObject; ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
    }
    public void ApagarTexto()
    {
        Mision = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<ShowMision>();
        Mision.NoCAll();
        MensajeCompletado.SetActive(false);
        ParteDelCuerpoElegida = ParteDelCuerpo;
        OcultarObjeto = GameObject.Find("Textos");
        if (ParteDelCuerpo == "Pie Derecho") { ParteEncontrada = OcultarObjeto.transform.GetChild(0).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Pie Izquierdo") { ParteEncontrada = OcultarObjeto.transform.GetChild(1).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Mano Derecha") { ParteEncontrada = OcultarObjeto.transform.GetChild(2).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Mano Izquierda") { ParteEncontrada = OcultarObjeto.transform.GetChild(3).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Cabeza") { ParteEncontrada = OcultarObjeto.transform.GetChild(4).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Brazo Derecho") { ParteEncontrada = OcultarObjeto.transform.GetChild(5).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Brazo Izquierda") { ParteEncontrada = OcultarObjeto.transform.GetChild(6).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Pecho") { ParteEncontrada = OcultarObjeto.transform.GetChild(7).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Parte Baja") { ParteEncontrada = OcultarObjeto.transform.GetChild(8).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Pierna Derecha") { ParteEncontrada = OcultarObjeto.transform.GetChild(9).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Pierna Izquierda") { ParteEncontrada = OcultarObjeto.transform.GetChild(10).gameObject; ParteEncontrada.SetActive(false); Linea.enabled = false; }
    }
    public string ElegirCaso(int caso)
    {
        switch (NumeroAleatorio)
        {
            case 0:
                ParteDelCuerpo = "Pie Derecho";
                break;
            case 1:
                ParteDelCuerpo = "Mano Derecha";
                break;
            case 2:
                ParteDelCuerpo = "Mano Izquierda";
                break;
            case 3:
                ParteDelCuerpo = "Cabeza";
                break;
            case 4:
                ParteDelCuerpo = "Pierna Derecha";
                break;
            case 5:
                ParteDelCuerpo = "Pierna Izquierda";
                break;
            case 6:
                ParteDelCuerpo = "Cuello";
                break;
            case 7:
                ParteDelCuerpo = "Cabeza2";
                break;
                /*case 8:
                    ParteDelCuerpo = "Parte Baja";
                    break;
                case 9:
                    ParteDelCuerpo = "Pierna Derecha";
                    break;
                case 10:
                    ParteDelCuerpo = "Pierna Izquierda";
                    break;*/
        }
        return ParteDelCuerpo;
    }
    /*public void RevisarCasos(){
        for(int i = 0; i < CasosQuitados.Count; i++){
            if(ParteDelCuerpo == CasosQuitados[i].name){
                NumeroAleatorio = Random.Range(0,10);
                ElegirCaso(NumeroAleatorio);
            }
        }
    }*/
}
