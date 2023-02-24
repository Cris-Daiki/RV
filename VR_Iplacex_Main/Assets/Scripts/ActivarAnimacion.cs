using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ActivarAnimacion : MonoBehaviour
{
    public Animator anim;
    public List<GameObject> IniciarReto;
    Evaluando ProgresoEvaluando;
    int contador = 0;
    int activate = 0;
    float timer = 0;
    public GameObject ObjetoQContieneLaAnimacion;
    // Start is called before the first frame update

    // Update is called once per frame
    public void ActivarAnimator()
    {
        ProgresoEvaluando =GameObject.FindGameObjectWithTag("RetoJugador").GetComponent<Evaluando>();
        if(contador == 0){
            anim.enabled = true;
            activate =1;
            timer=0;
            contador+= 1;
        }else{
            timer = 0;
            activate =2 ;
            contador -=1;
            
        }
    }
    void Update(){
        timer += Time.deltaTime;
        if(activate == 1){
            foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                children.gameObject.layer =0;
            }
            if(timer >= 1.4f){
                for(int i = 0; i< IniciarReto.Count; i++){
                    IniciarReto[i].SetActive(true);
                }
                foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                    children.gameObject.layer =6;
                }
            }
        }
        if(activate == 2){
            foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                children.gameObject.layer =0;
            }
            if(timer >= 1.4f){
                for(int i = 0; i< IniciarReto.Count; i++){
                    IniciarReto[i].SetActive(false);
                }
                foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                    children.gameObject.layer =6;
                }
                ProgresoEvaluando.Reseteo();
            }
        }
    }
}
