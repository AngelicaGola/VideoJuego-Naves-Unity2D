using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour
{
    public float velocidadMeteoro;
    Rigidbody2D rb2D;

    [SerializeField] private float vida;
   

    public int daño = 1;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = Vector2.down * velocidadMeteoro;
        Destroy(this.gameObject, 4);
    }

    void Colision()
    {
        
        Score.puntajeActual.ActualizarPuntaje();
        print("Asteroide Colision");
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player")){
            Destroy(gameObject);
            collision.SendMessageUpwards("AddDamage", daño);
 
        }

    }

 




}
