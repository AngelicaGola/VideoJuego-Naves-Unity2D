using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text t;
    public int puntaje;


    //public RectTransform PuntajeUI;

    public static Score puntajeActual;
    


    // Start is called before the first frame update
    void Start()
    {
        puntajeActual = this;
    }


    // Update is called once per frame
    public void ActualizarPuntaje()
    {
        puntaje++;
        t.text = puntaje.ToString();

    }
}
