using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidadBala;
    public float limite;
    [SerializeField] private GameObject efectoExplosion;

    // private int balas;

    //public static Bala Numbalas;


    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * velocidadBala);

        if (transform.position.y >= limite)
        {
           gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Meteoro")//(other.CompareTag ("Meteoro"))//if (collision.CompareTag("Meteoro"))
        {
            // other.GetComponent<Meteoro>().VidaEnemigo(dañoEne);
            other.SendMessage("Colision", SendMessageOptions.DontRequireReceiver);
            Instantiate(efectoExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);

            
        }
    }




}
