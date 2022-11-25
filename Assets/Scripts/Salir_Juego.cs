using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir_Juego : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Has salido del Juego");
    }
}
