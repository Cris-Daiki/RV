using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraInteration : MonoBehaviour{

    public new Transform camera;
    public float rayDistance;
    public float timer = 0;   
    string Comparation,Comparation2;
    int contador =1;
    float timer2;

    void Update()
    {

        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.red);


        RaycastHit hit;

       
        if(Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable")) && contador ==1){
            Comparation = hit.collider.name;
            contador+=1;
            
        }
        if(contador != 1 ){
            timer2 += Time.deltaTime;
        }

        if(Physics.Raycast(camera.position, camera.forward, out hit, rayDistance, LayerMask.GetMask("Interactable")) && contador ==2){
            
            Comparation2 = hit.collider.name;
            timer += Time.deltaTime;
            timer2 = 0;
            /*if(Input.GetButtonDown("Interactable")){
                hit.transform.GetComponent<Interactable>().Interact();
                timer = 0;
            } */

            
            if(timer >=1.5f){
                hit.transform.GetComponent<Interactable>().Interact();
                timer = 0;
                
            }else{
                if(Comparation != Comparation2){
                    timer=0;
                    contador-=1;  
                }
            }
              
        }
        if(timer2 >= 1.5f){
                timer = 0;
                timer2 = 0;
            }
    }
}
