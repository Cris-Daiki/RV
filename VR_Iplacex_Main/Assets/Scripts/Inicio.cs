using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public GameObject IntroRV1,IntroRV2;
    float timer;
    // Start is called before the first frame update
    void Start()
    {   
        IntroRV1.SetActive(true);
        timer = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer +=Time.deltaTime;
        if(timer >= 4){
            IntroRV1.SetActive(false);
            IntroRV2.SetActive(true);
        }
    }
}
