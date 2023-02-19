using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColo : MonoBehaviour
{   
    private float timerCC = 0;  
    public GameObject Button1;
    public GameObject Button2;

    public void ChangeColorButton1press(){
        timerCC = 0;
        Button1.GetComponent<Renderer>().material.color =  new Color32(0, 255,0, 255);
        
    }
    
    public void ChangeColorButton1(){

        Button1.GetComponent<Renderer>().material.color =  new Color32(255, 0,0,255);
    }

    public void ChangeColorButton2press(){
        timerCC = 0;
        Button2.GetComponent<Renderer>().material.color =   new Color32(67, 149,1, 255);

        
    }
    
    public void ChangeColorButton2(){

        Button2.GetComponent<Renderer>().material.color =  new Color32(255, 0,0,255);
    }
    void Update(){
        timerCC += Time.deltaTime;
        if(timerCC >= 0.5f){
            ChangeColorButton1();
            ChangeColorButton2();
        }
    }
}
