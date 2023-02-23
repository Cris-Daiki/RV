using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowMision : MonoBehaviour
{
    public List<string> TextValue;
    //public Text textElement;
    public GameObject Mision;
    public TMP_Text textElement;
    ShowTexto Numero;
    public void Call()
    {
        Mision.SetActive(true);
        Numero = FindObjectOfType<ShowTexto>();
        textElement.text = TextValue[Numero.NumeroAleatorio];
    }
    public void NoCAll()
    {
        Mision.SetActive(false);
    }
}
