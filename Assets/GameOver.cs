using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text f;
    public Text fprom;
    public Text puntajeActual;
    public Text fmax;
   
  

    //public string NombreNivel;
    private float FuerzaActual;
    private float FuerzaProm;
    private double FuerzaMax;
    private int ScoreActual;


    public GameObject Tiempo;
    public GameObject Puntaje;
    public GameObject Jugador;
    public GameObject Meteoro;
    public GameObject Vida;

    
    public void Setup()
    {
        gameObject.SetActive(true);
        Tiempo.SetActive(false);
        Puntaje.SetActive(false);
        Jugador.SetActive(false);
        Meteoro.SetActive(false);
        Vida.SetActive(false);


    }
    public void Update()
    {
        ControlJugador controljugador = GetComponent<ControlJugador>();
        Score variableS = GetComponent<Score>();

        FuerzaActual = controljugador.Fuerza;
        FuerzaProm = controljugador.promedio;
        FuerzaMax = controljugador.FuerzaMax;
        ScoreActual = variableS.puntaje;

        f.text = FuerzaActual.ToString() + "Kg";
        fprom.text = FuerzaProm.ToString("F2") + "Kg";
        fmax.text = FuerzaMax.ToString("F2") + "Kg";
        puntajeActual.text = ScoreActual.ToString();
        
    }

    public void ReatryBoton(string NombreNivel)
    {
        SceneManager.LoadScene(NombreNivel);
    }


    public void SalidaBoton()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
