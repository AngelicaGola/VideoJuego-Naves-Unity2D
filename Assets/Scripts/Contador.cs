using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    public Text contador;
    public float tiempo;

    //Fin del Juego 
    public RectTransform finJuegoMenu;
    public GameOver GameOver1;

    // Start is called before the first frame update
    void Start()
    {
        contador.text = " " + tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime ;
        contador.text = " " + tiempo.ToString("f0");

        if (tiempo <= 0)
        {

            finJuegoMenu.gameObject.SetActive(true);
            GameOver1.Setup();
        }
    }


}
