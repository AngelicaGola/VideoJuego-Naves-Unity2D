using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerarMeteoro : MonoBehaviour
{
    public GameObject[] Enemigos;
    private int seleccionEnemigo;
    public float tiempo;
    private float vtiempo;
    // Start is called before the first frame update
    void Start()
    {
        CrearEnemigos();
    }

    // Update is called once per frame
    void Update()
    {
        vtiempo += Time.deltaTime;
        if (vtiempo > tiempo)
        {
            CrearEnemigos();
            vtiempo = 0;
        }
    }

    void CrearEnemigos()
    {
        seleccionEnemigo = Random.Range(0, Enemigos.Length);
        Vector2 posicion = new Vector2(Random.Range(-2.3f, 2.3f), transform.position.y);

        Instantiate(Enemigos[seleccionEnemigo], posicion, Quaternion.identity);
    }
}
