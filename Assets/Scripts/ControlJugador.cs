using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{
    //Puerto serial
    SerialPort serialPort = new SerialPort("COM10", 9600);


    //Jugador 
    public float velocidad;
    private int vidaActual;
    private float tiempoActual;


    //Sensores
    public float Fuerza; // celda de carga
    private int dirx, diry, dirz; //MPU650

    
    Rigidbody2D rb2D;
    Vector2 movimiento;

    //bala
    [SerializeField] public GameObject balaPrefab;
    [SerializeField] public Transform cañon;

    //Fuerza según característcias de cada nivel 
    public int minFuerza;
    public int tEspera;
    
    private int n; //nivel del juego

    int contador = 0;
    float [] datosFuerza= new float [100];
    int en =0;
    float suma = 0;
    public double FuerzaMax = 0;//-100; //Valor Fuerza Maxima Registrada
    public float promedio=0;


    void Start()
    {
        serialPort.Open();
        serialPort.ReadTimeout = 100;
    }


    // Start is called before the first frame update
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        if (serialPort.IsOpen)
        {
            try
            {
                separar(serialPort.ReadLine());
                movimiento = new Vector2(dirz, dirx);
                Debug.Log("La fuerza es " + Fuerza);
                FuerzaPromedio();
                FuerzaMaxima();
            }

            catch (System.Exception ex)
            {
                ex = new System.Exception();
            }
        }


        if (Fuerza > minFuerza) // si la fuerza es mayor a F recibida va a disparar 
        {
            contador++;
            //Debug.Log("EL contador va en " + contador);
            if (contador > tEspera)
            {
                Disparar();
                //print("DISPARO");
            }
        }
        else
        {
            contador = 0;
        }

        VidaJugador variableVida = GetComponent<VidaJugador>();
        vidaActual = variableVida.vidas;
        //tiempoActual -= Time.deltaTime;
        //Debug.Log("El tiempo es " + tiempoActual.ToString("F1"));
        //Debug.Log("El vida del jugador ahora  es " + vidaActual);

    }

    private void FixedUpdate()
    {
        transform.Translate(movimiento * velocidad);
        limitarovimiento();
    }

    void limitarovimiento()
    {
        Vector2 posicionLimitada = transform.position;

        posicionLimitada.x = Mathf.Clamp(posicionLimitada.x, -2.3f, 2.3f);
        posicionLimitada.y = Mathf.Clamp(posicionLimitada.y, -1.25f, 0.7f);


        transform.position = posicionLimitada;
    }

    void Disparar()
    {
        Instantiate(balaPrefab, cañon.position, cañon.rotation);
    }




    void separar(string datArduino)
    {
        string[] dAr = datArduino.Split(char.Parse(","));

        if (dAr.Length == 4)
        {
            Fuerza = int.Parse(dAr[0]);
            dirx = int.Parse(dAr[1]) / 100;
            diry = int.Parse(dAr[2]) / 100;
            dirz = int.Parse(dAr[3]) / 100;

        }

        
    }

    void FuerzaPromedio()
    {
        datosFuerza[en] = Fuerza;
        en++;
        //Debug.Log("El # de datos es " + en);
            suma = 0;
            for (int i = 0; i < en; i++)
            {
                suma += datosFuerza[i];
            }
            promedio = suma /en;
            
           // Debug.Log("El promedio es " + promedio.ToString("F2"));
        
    }

    void FuerzaMaxima()
    {
        if (Fuerza > FuerzaMax)
        {
            FuerzaMax = Fuerza;
            //Debug.Log("MAXIMA " + FuerzaMax.ToString("F2"));
        }
    }

    public void LeerVarEntada_1(string Te)
    {
        tEspera = int.Parse(Te);
        Debug.Log(tEspera);
       
    }

    public void LeerVarEntada_2(string Fm)
    {
        minFuerza = int.Parse(Fm);
        Debug.Log(minFuerza);
    }


}
