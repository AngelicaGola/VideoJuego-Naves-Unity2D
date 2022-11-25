using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    public int totalVidas = 3;
    public RectTransform vidasUI;

    public int vidas;
    private float tamañovidas = 16f;

    private SpriteRenderer _render;

    //Fin del Juego 
    public GameOver GameOver;


    private void Awake()
    {
        _render = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        vidas = totalVidas;
    }

    public void AddDamage(int cantidad)
    {
        vidas = vidas - cantidad;

        // juego terminado 
        if (vidas <= 0)
        {
            vidas = 0;
            
            GameOver.Setup();

        }
        vidasUI.sizeDelta = new Vector2(tamañovidas * vidas, tamañovidas);
        Debug.Log("El jugador ha sufrido un daño. Su vida actual es de " + vidas);
    }

    public void AddVida(int cantidad)
    {
        vidas = vidas + cantidad;

        // Maxima cantidad de vidas 
        if (vidas > totalVidas)
        {
            vidas = totalVidas;

        }
        Debug.Log("El jugador tiene un poco más de vida. Su vida actual es de " + vidas);
    }

    private void OnEnable()
    {
        //vidas = totalVidas;
        
    }

    private void OnDisable()
    {


    }


}
