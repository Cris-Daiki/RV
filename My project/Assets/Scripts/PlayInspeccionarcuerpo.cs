using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayInspeccionarcuerpo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Inicio()
    {
        print("entre");
        SceneManager.LoadScene("Menu_Inspeccion_Cuerpo");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
