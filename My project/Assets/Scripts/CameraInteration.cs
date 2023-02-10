using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraInteration : MonoBehaviour{

    public new Transform camera;
    public float rayDistance;
    public float timer = 0;   
    string Comparation,Comparation2;
    int contador =1;

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
