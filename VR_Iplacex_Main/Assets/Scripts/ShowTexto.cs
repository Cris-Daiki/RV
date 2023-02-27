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

        if (ParteDelCuerpo == "Pie Derecho") {ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Pie Izquierdo") { ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Mano Derecha") { ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Mano Izquierda") { ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Cabeza") { ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Brazo Derecho") { ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Brazo Izquierda") { ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Pecho") { ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Parte Baja") { ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Pierna Derecha") { ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Pierna Izquierda") {ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Cuello") { ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
        if (ParteDelCuerpo == "Cabeza2") { ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(true); Linea = Objeto.GetComponent<LineRenderer>(); Linea.enabled = true; }
    }
    public void ApagarTexto()
    {

        Mision = GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<ShowMision>();
        Mision.NoCAll();
        MensajeCompletado.SetActive(false);
        ParteDelCuerpoElegida = ParteDelCuerpo;
        if (ParteDelCuerpo == "Pie Derecho") {ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Pie Izquierdo") {ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Mano Derecha") { ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Mano Izquierda") { ParteEncontrada = ObtenerElObjetoHIjo();ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Cabeza") { ParteEncontrada = ObtenerElObjetoHIjo();ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Brazo Derecho") {ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Brazo Izquierda") {ParteEncontrada = ObtenerElObjetoHIjo();  ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Pecho") {ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Parte Baja") { ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Pierna Derecha") { ParteEncontrada = ObtenerElObjetoHIjo();ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Pierna Izquierda") { ParteEncontrada = ObtenerElObjetoHIjo(); ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Cuello") { ParteEncontrada = ObtenerElObjetoHIjo();ParteEncontrada.SetActive(false); Linea.enabled = false; }
        if (ParteDelCuerpo == "Cabeza2") { ParteEncontrada = ObtenerElObjetoHIjo();ParteEncontrada.SetActive(false); Linea.enabled = false; }
    
    }
    public GameObject ObtenerElObjetoHIjo(){
        OcultarObjeto = GameObject.Find("Textos");
        print(OcultarObjeto);
        int n = OcultarObjeto.transform.childCount;
        if(n>0){
            for(int i = 0; i< n; i++){
                if("Dolor"+ParteDelCuerpo == OcultarObjeto.transform.GetChild(i).gameObject.name ){
                    ParteEncontrada = OcultarObjeto.transform.GetChild(i).gameObject;
                    break;
                }
            }
        }
        return ParteEncontrada;
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
