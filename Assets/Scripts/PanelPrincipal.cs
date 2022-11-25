using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class PanelPrincipal : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject panelprincipal;
    public GameObject opciones;
    public GameObject jugar;

    public void OpenPanel( GameObject panel)
    {
        panelprincipal.SetActive(false);
        opciones.SetActive(false);
        jugar.SetActive(false);

        panel.SetActive(true);
    }

    public void PlayLevel(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }


}
