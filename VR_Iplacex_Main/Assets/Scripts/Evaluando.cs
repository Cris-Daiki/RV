
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
    Tutorial TutorialIniciado;
    public List<GameObject> OrdenCorrectoDolor;
    public List<GameObject> OrdenCorrectoDolorPieDerecho;
    //public List<GameObject> OrdenCorrectoDolorPieIzquierda;
    public List<GameObject> OrdenCorrectoDolorManoDerecha;
    public List<GameObject> OrdenCorrectoDolorManoIzquierda;
    public List<GameObject> OrdenCorrectoDolorCabeza;
    //public List<GameObject> OrdenCorrectoDolorBrazoDerecho;
    //public List<GameObject> OrdenCorrectoDolorBrazoIzquierda;
    //public List<GameObject> OrdenCorrectoDolorPecho;
    //public List<GameObject> OrdenCorrectoDolorParteBaja;
    public List<GameObject> OrdenCorrectoDolorPiernaDerecha;
    public List<GameObject> OrdenCorrectoDolorPiernaIzquierda;
    public List<GameObject> OrdenCorrectoDolorCuello;
    public List<GameObject> OrdenCorrectoDolorCabeza2;

    private MostrarObjetosMostrador QuitarElementosMostrador;
    public GameObject MensajeGanaste,Tutor;
    public List<GameObject> ListaDeMensajesDeRetoComopletado;
    ShowTexto ParteDelCuerpo,activate;
    public List<GameObject> ObjetosJuego;
    int indice;
    float progreso=0f;
    int ActivarFixedUpdate;
    string ProblemaCuerpo;
    internal int Completado = 0;
    float time;
    ActivarAnimacion ContadorAnimacion;
    //public TMpro.TextMeshProUGUI Porcentaje;
    public void Jugando(){

        ElementoElegido = FindObjectOfType<EligiendoElementos>();
        ParteDelCuerpo = FindObjectOfType<ShowTexto>();
        activate = GameObject.FindGameObjectWithTag("Texto").GetComponent<ShowTexto>();
        TutorialIniciado= FindObjectOfType<Tutorial>();
        ProblemaCuerpo = ParteDelCuerpo.ParteDelCuerpoElegida;
        
        
        if(TutorialIniciado.ActivoTutorial){
            print("Se activo el Tutorial");
            OrdenCorrectoDolor = Obtener(ParteDelCuerpo.ParteDelCuerpoElegida);
            if (ElementoElegido.ObjetosElegidos.Count == OrdenCorrectoDolor.Count)
            {
                bool isEqual = ElementoElegido.ObjetosElegidos.ToHashSet().SetEquals(OrdenCorrectoDolor);
                if (isEqual)
                { //completamos
                    //ParteDelCuerpo.CasosQuitados.Add(ParteDelCuerpo.ParteDelCuerpoElegida);
                    Completado = 1;
                    progreso = ((float)ElementoElegido.ObjetosElegidos.Count / OrdenCorrectoDolor.Count);
                    ActivarFixedUpdate += 1;
                    Reseteo();
                    activate.ApagarTexto();
                    time = 0;

                    //hacer funcion que elimine este problema y que vuelva todo a lo original 
                }
                else
                {
                    ActivarFixedUpdate += 1;
                    Reseteo();
                }
            }
            else
            {
                indice = ElementoElegido.ObjetosElegidos.Count;
                for (int i = 0; i < indice; i++)
                {
                    if (ElementoElegido.ObjetosElegidos[i] == OrdenCorrectoDolor[i])
                    {
                        progreso = ((float)ElementoElegido.ObjetosElegidos.Count / OrdenCorrectoDolor.Count);
                    }
                    else
                    {
                        Reseteo();
                        break;
                    }
                }
                ActivarFixedUpdate += 1;
            }

        }else{
            OrdenCorrectoDolor= Obtener(ParteDelCuerpo.ParteDelCuerpoElegida);
            if (ElementoElegido.ObjetosElegidos.Count == OrdenCorrectoDolor.Count)
            {
                bool isEqual = ElementoElegido.ObjetosElegidos.ToHashSet().SetEquals(OrdenCorrectoDolor);
                if (isEqual)
                { //completamos
                    //ParteDelCuerpo.CasosQuitados.Add(ParteDelCuerpo.ParteDelCuerpoElegida);
                    Completado = 1;
                    progreso = ((float)ElementoElegido.ObjetosElegidos.Count / OrdenCorrectoDolor.Count);
                    ActivarFixedUpdate += 1;
                    Reseteo();
                    activate.ApagarTexto();
                    time = 0;

                    //hacer funcion que elimine este problema y que vuelva todo a lo original 
                }
                else
                {
                    ActivarFixedUpdate += 1;
                    Reseteo();
                }
            }
            else
            {
                indice = ElementoElegido.ObjetosElegidos.Count;
                for (int i = 0; i < indice; i++)
                {
                    if (ElementoElegido.ObjetosElegidos[i] == OrdenCorrectoDolor[i])
                    {
                        progreso = ((float)ElementoElegido.ObjetosElegidos.Count / OrdenCorrectoDolor.Count);
                    }
                    else
                    {
                        Reseteo();
                        break;
                    }
                }
                ActivarFixedUpdate += 1;
            }
        }
        
    }
    private void FixedUpdate()
    {
        if (ActivarFixedUpdate != 0)
        {
            BarraCarga.fillAmount = Mathf.Lerp(BarraCarga.fillAmount, progreso, .05f);
        }
        time += Time.deltaTime;
        if (Completado == 1)
        {

            //if(time <= 2f)
            //{
            for (int i = 0; i < ListaDeMensajesDeRetoComopletado.Count; i++)
            {
                ListaDeMensajesDeRetoComopletado[i].SetActive(false);
            }
            MensajeGanaste.SetActive(true);
            for (int i = 0; i < ListaDeMensajesDeRetoComopletado.Count; i++)
            {
                if (ParteDelCuerpo.ParteDelCuerpoElegida == ListaDeMensajesDeRetoComopletado[i].name)
                {
                    ListaDeMensajesDeRetoComopletado[i].SetActive(true);
                }
            }

            //}else{
            //MensajeGanaste.SetActive(false);
            Completado = 0;
            progreso = 0;
            //}
        }
    }
    public void Reseteo()
    {
        ContadorAnimacion= FindObjectOfType<ActivarAnimacion>();
        if(ContadorAnimacion.contador == 1){
            for (int x = 0; x < ObjetosJuego.Count; x++)
            {
                ObjetosJuego[x].SetActive(true);
            }
        }else{
            print("Primero abre el Botiquin");
        }
        progreso = 0f;

        QuitarElementosMostrador = GameObject.FindGameObjectWithTag("MostradorObjetos").GetComponent<MostrarObjetosMostrador>();

        QuitarElementosMostrador.DesactivarObjetosMostrador();
        ElementoElegido = FindObjectOfType<EligiendoElementos>();
        ElementoElegido.ObjetosElegidos.Clear();
    }
    public void CompletoReto()
    {
        for (int x = 0; x < ObjetosJuego.Count; x++)
        {
            ObjetosJuego[x].SetActive(false);
        }
    }
    public List<GameObject> Obtener(string ProblemaCuerpo){
        if (ProblemaCuerpo != "Null")
        {
            switch (ProblemaCuerpo)
            {
                case "Pie Derecho":
                    OrdenCorrectoDolor = OrdenCorrectoDolorPieDerecho;
                    break;
                //case "Pie Izquierdo":
                //    OrdenCorrectoDolor = OrdenCorrectoDolorPieIzquierda;
                //    break;
                case "Mano Derecha":
                    OrdenCorrectoDolor = OrdenCorrectoDolorManoDerecha;
                    break;
                case "Mano Izquierda":
                    OrdenCorrectoDolor = OrdenCorrectoDolorManoIzquierda;
                    break;
                case "Cabeza":
                    OrdenCorrectoDolor = OrdenCorrectoDolorCabeza;
                    break;
                /*case "Brazo Derecho":
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
                    break;*/
                case "Pierna Derecha":
                    OrdenCorrectoDolor = OrdenCorrectoDolorPiernaDerecha;
                    break;
                case "Pierna Izquierda":
                    OrdenCorrectoDolor = OrdenCorrectoDolorPiernaIzquierda;
                    break;
                case "Cuello":
                    OrdenCorrectoDolor = OrdenCorrectoDolorCuello;
                    break;
                case "Cabeza2":
                    OrdenCorrectoDolor = OrdenCorrectoDolorCabeza2;
                    break;
            }

        }
        return OrdenCorrectoDolor;
    }
    public void Tutorial(){

    }

    /*void Update(){
        time+= Time.deltaTime;
    }*/
}
