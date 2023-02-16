using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraInteration : MonoBehaviour
{
 public new Transform camera;
    public float rayDistance;
    public float timer = 0;   
    string Comparation,Comparation2;
    int contador =1;
    internal string NombreParteJuego;

    void Update()
    {

        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);


        RaycastHit hit;


       
        if(Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable")) && contador ==1){
            Comparation = hit.collider.name;
            print(Comparation);
            contador+=1;
        }
        if(Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable")) && contador ==2){
            
            Comparation2 = hit.collider.name;
            print(Comparation2+"   " +Comparation);
            timer += Time.deltaTime;

            /*if(Input.GetButtonDown("Interactable")){
                hit.transform.GetComponent<Interactable>().Interact();
                timer = 0;
            } */


            if(timer >=3f){
                /*if(hit.collider.name == "Pie Derecho" || hit.collider.name == "Pie Izquierdo" ||hit.collider.name == "Mano Derecha" ||hit.collider.name == "Mano Izquierda" ||
                hit.collider.name == "Cabeza" ||hit.collider.name == "Brazo Derecho" ||hit.collider.name == "Brazo Izquierda" ||hit.collider.name == "Pecho" ||
                hit.collider.name == "Parte Baja" ||hit.collider.name == "Pierna Derecha" ||hit.collider.name == "Pierna Izquierda" ){
                    NombreParteJuego = hit.transform.root.name;
                    print(NombreParteJuego);
                }*/
                hit.transform.GetComponent<Interactable>().Interact();
                
                timer = 0;
                
            }else{
                if(Comparation != Comparation2){
                    timer=0;
                    contador-=1;  
                }
            }
              
        }
    }
}
