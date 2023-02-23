using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    public int parar = 0;
    public Animacion animacion;



    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void call()
    {
        parar += 1;
    }
    void Update()
    {
       /* if(parar ==1)
        {
            animator.SetBool("AbrirTapa", true);
            parar += 1;
        }
        else { animator.SetBool("AbrirTapa", false); }*/
        
        
    }
}

