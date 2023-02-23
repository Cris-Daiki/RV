using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Untagged



public class CambiarModeloUnico : MonoBehaviour
{


    public List<GameObject> myList;

    Despliegue ApagarLista;  //usamos esta variable para obtener la lista con los gameobjects de los modelos para apagarlo o encenderlo

    float x, y, z; //esta variable se usa simplemente para guardar el valor del escalado al momento de inspeccionar un objeto

    public GameObject Botiquin; //Con esta variable guardamos el objeto botiquin para encenderlo en el momento que se necesesite

    internal Rotation rotacion; //con esta variable guardamos el componente Rotation en donde ocurre la rotacion automatica del objeto, esta la obtenemos para activar o desactivar el componente cuando se necesite

    internal Vector3 Posicion; //guardamos la posicion original del objeto que se va a inspeccionar para luego de su inspeccion volver a su posicion original

    Quaternion rotacionDelObjeto; //con este Quaternion nos aseguramos que ciertos objetos planos esten en una posicion de 90° la cual nos permita una mejor observacion y estos luego de la inspeccion pueda volver a su posicion y rotacion original
    
    internal int contadorRotation = 0; // esta variable nos permite saber si el objeto esta rotanto actualmente o no, dependiendo el caso sabremos si necesitamos apagarlo o encenderlo 
    
    internal GameObject ObjetoReferenciado; // con esta variable podremos saber el objeto con el cual el usuario interactua, esta variable se obtiene de otros codigos que tienen nocion de que objeto es el cual el usuario esta interactuando
    
    internal int contador = 0;//esta variable nos permite saber si el usuario esta inspeccionando algun objeto o no, esta variable nos permite saber si necesitamos desplegar un objeto para su inspeccion o debemos volver un paso atras permitiendo al usuario elegir otro objeto a inspeccionar
    
    internal string NombreEncontrado; //esta variable nos permite guardar la variable nombre que es el nombre del objeto que se esa interacciontuando asi mismo nos permite dar el objeto completo a la variable ObjetoReferenciado
    
    protected CambioModelo ContadorDelModelo; //nos permite saber si al momento de volver el objeto a su posicion original es necesario desactivar la rotacion del objeto y tambien nos permite saber si el boton de ON/OFF se le debe permitir su uso o no 

    //ActivarDespliegue NombreContenedor,Funcion;

    Despliegue ContadorVolver;  //nos permite saber si algun contenedor que contiene los objetos  esta desplegados 

    //int contadorPrestadoMU;

    public void WhenUserSee(string Nombre) //esta funcion nos permite desplegar el objeto o volverlo a su posicion original dependiendo del objeto con el que el usuario interactua
    {
        ContadorVolver =FindObjectOfType<Despliegue>();
        try
        {
            NombreEncontrado = Nombre;
            ObjetoReferenciado = GameObject.Find(Nombre);
        }
        catch
        {
            print("ERROR AL ASIGNAR VALORES EN WHENUSERSEE");
        }


        try
        {
            if ((contador % 2) == 0)
            {
                
                ContadorVolver.contadorDespliegue +=1;
                for (int i = 0; i < 16; i++)
                {
                    myList[i].SetActive(false);
                }

                ObjetoReferenciado.SetActive(true);

                x = 3;
                y = 3;
                z = 3;
                Posicion = ObjetoReferenciado.transform.position;
                rotacionDelObjeto = ObjetoReferenciado.transform.rotation;
                ObjetoReferenciado.transform.localScale = new Vector3(x, y, z);
                ObjetoReferenciado.transform.position = new Vector3(-0.330000013f, 9.54899979f, -0.109999999f);

                //ObjetoReferenciado.transform.position = new Vector3();
                if (ObjetoReferenciado.name == "apositoabsorvente" || ObjetoReferenciado.name == "tijera" || ObjetoReferenciado.name == "algodon" ||
                ObjetoReferenciado.name == "gasanotejida10x10" || ObjetoReferenciado.name == "clorurodesodio" || ObjetoReferenciado.name == "alcoholpad" ||
                ObjetoReferenciado.name == "gasaparafinada" || ObjetoReferenciado.name == "gasanotejida5x5" || ObjetoReferenciado.name == "jeringa" ||
                ObjetoReferenciado.name == "palomedico" || ObjetoReferenciado.name == "apositogasa" || ObjetoReferenciado.name == "apositoespuma")
                {
                    ObjetoReferenciado.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                }
                UpdateRotation(Nombre);

                ObjetoReferenciado.layer = 0;
                foreach (Transform children in this.ObjetoReferenciado.transform){
                    children.gameObject.layer =0;
                }
                
                contador += 1;
            }
            else
            {
               
                ObjetoReferenciado.transform.position = Posicion;
                ObjetoReferenciado.transform.rotation = rotacionDelObjeto;
                UpdateRotation(Nombre);
                //Update2(Nombre);
                Update4(Nombre);
                contador += 1;
                ContadorVolver.contadorDespliegue -=1;
                x = 1;
                y = 1;
                z = 1;
            }
        }
        catch
        {
            print("Error al actualizar la posicion o rotacion del objeto para su inspeccion, por favor revisar" + "\n" + ObjetoReferenciado + "Revisar el estado actual del objeto");
        }
    }
    public void Update2(string Nombre) //esta funcion actualmente esta en desuso 
    {

        
        Botiquin.SetActive(true);
        ApagarLista = GameObject.FindGameObjectWithTag("DesplegarObjetos").GetComponent<Despliegue>();
        /*ContadorDespliegueScript = FindObjectOfType<Despliegue>();
        ContadorDespliegueScript.contadorDespliegue-=1;*/
        
        //NombreContenedor =FindObjectOfType<ActivarDespliegue>();

        /*ApagarLista.WhenDespligue1OFF();
        ApagarLista.WhenDespligue2OFF();
        ApagarLista.WhenDespligue3OFF();
        ApagarLista.WhenDespligue4OFF();
        ApagarLista.WhenDespligue5OFF();
        ApagarLista.WhenDespligue6OFF();
        ApagarLista.WhenDespligue7OFF();*/


        /*for (int i = 0; i < 16; i++)
        {
            myList[i].SetActive(true);
        }*/

    }

    public void UpdateRotation(string Nombre) //nos permite activar o desactivar el componente de rotacion que tienen asignado los objetos que se inspeccionan
    {
        rotacion = GameObject.Find(Nombre).GetComponent<Rotation>();
        ContadorDelModelo = FindObjectOfType<CambioModelo>();

        //contadorPrestadoMU = ContadorDelModelo.contadorCambioModelo;

        print("CONTADOR DE LA ROTACION; PAR PARA ROTAR; IMPAR PARA PARAR"+contadorRotation);
        if ((contadorRotation % 2) == 0)
        {
            rotacion.enabled = true;
            contadorRotation += 1;
        }
        else
        {
            rotacion.enabled = false;
            contadorRotation += 1;
        }
    }
    public void Update3() //nos permite apagar todos los contenedores para que se vuelva a la posicion original en donde el usuario solo tiene el botiquin con los objetos dentro de los contenedores 
    {
        ApagarLista = GameObject.FindGameObjectWithTag("DesplegarObjetos").GetComponent<Despliegue>();
        //ContadorDespliegueScript = FindObjectOfType<Despliegue>();
        //ContadorDespliegueScript.contadorDespliegue-=1;

        ApagarLista.WhenDespligue1OFF();
        ApagarLista.WhenDespligue2OFF();
        ApagarLista.WhenDespligue3OFF();
        ApagarLista.WhenDespligue4OFF();
        ApagarLista.WhenDespligue5OFF();
        ApagarLista.WhenDespligue6OFF();
        ApagarLista.WhenDespligue7OFF();
    }



    Despliegue DesplegarContenedor; //esta variable nos permite obtener las fucniones de otro script y activarlas a conveniencia
    public void Update4(string Nombre) //esta funcion nos permite activar el despliegue de un contenedor en especifico dependiendo del objeto con el que interactuo la primera vez que desplego el contenedor para elegir el modelo a inspeccionar
    {

        try
        {
            ObjetoReferenciado = GameObject.Find(Nombre);

            ObjetoReferenciado.transform.localScale = new Vector3(1,1,1);
        }
        catch
        {
            print("Error al asignar valores a las variables");
        }
        DesplegarContenedor = GameObject.FindGameObjectWithTag("DesplegarObjetos").GetComponent<Despliegue>();
        
        Botiquin.SetActive(true);
        if(Nombre == "cinta"|| Nombre=="tijera" || Nombre == "alcohol"|| Nombre == "algodon"|| Nombre=="cintamedica"){
            DesplegarContenedor.WhenDespligue1ON();
        }
        if(Nombre == "clorurodesodio" || Nombre == "apositogasa"){
            DesplegarContenedor.WhenDespligue2ON();
        }

        if(Nombre == "gasanotejida5x5"||Nombre == "palomedico"){
            DesplegarContenedor.WhenDespligue3ON();
        }
        if(Nombre == "jeringa" || Nombre == "apositoespuma"){
            DesplegarContenedor.WhenDespligue4ON();
        }
        if(Nombre == "alcoholpad"){
            DesplegarContenedor.WhenDespligue5ON();
        }
        if(Nombre == "apositoabsorvente"){
            DesplegarContenedor.WhenDespligue6ON();
        }
        if(Nombre == "gasanotejida10x10" || Nombre == "gasaparafinada"){
            DesplegarContenedor.WhenDespligue7ON();
        }

    }
}