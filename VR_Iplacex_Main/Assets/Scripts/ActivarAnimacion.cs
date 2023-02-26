using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ActivarAnimacion : MonoBehaviour
{
    public Animator anim;
    public List<GameObject> IniciarReto;
    Evaluando ProgresoEvaluando;
    internal int contador = 0;
    int activate = 0;
    float timer = 0;

    public GameObject ObjetoQContieneLaAnimacion;
    public BoxCollider BoxColliderTapa,BoxColliderBase;
    // Start is called before the first frame update

    // Update is called once per frame
    public void ActivarAnimator()
    {


        if(contador == 0){
            anim.SetBool("ActivarAbrir", true);
            activate =1;
            timer=0;
            contador+= 1;
        }
    }
    void Update(){
        timer += Time.deltaTime;
        if(activate == 1){
            foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                children.gameObject.layer =0;
            }
            BoxColliderTapa.enabled = false;
            BoxColliderBase.enabled = false;
            if(timer >= 1.4f){
                anim.SetBool("ActivarAbrir", false);
                for(int i = 0; i< IniciarReto.Count; i++){
                    IniciarReto[i].SetActive(true);
                }
                activate= 0;
            }
        } 
        /*if(activate == 2){
            print("AOSIDJAOSIJDNAOSIDJOAISJDOAISDJoAISD");
            anim.SetBool("Activar", true);
            foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                children.gameObject.layer =0;
            }
            print("YA SE HIZO LA ANI SE SUPONTE");

            if(timer >= 1.4f){
                for(int i = 0; i< IniciarReto.Count; i++){
                    IniciarReto[i].SetActive(false);
                }
                foreach (Transform children in this.ObjetoQContieneLaAnimacion.transform){
                    children.gameObject.layer =6;
                }
                activate= 0;
                anim.SetBool("Activar", false);
                ProgresoEvaluando.Reseteo();
            }
        }*/
    }
}
