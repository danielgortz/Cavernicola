using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequenio2: MonoBehaviour
{
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private GameObject heroeJugador;
    public bool cerca;
    public float velocidadCaminar = 5;
    public int puntosDanio = 15;
    public float rangoAgro = 3;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        heroeJugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        bool enemigoVivo = this.GetComponent<Personaje>().muerto;
        bool heroeVivo = heroeJugador.GetComponent<Personaje>().muerto;
        Vector3 miPos = this.transform.position;
        Vector3 posHeroe = heroeJugador.transform.position;
        float distanciaHeroe = (miPos - posHeroe).magnitude;
        if (distanciaHeroe < rangoAgro)
        {//heroe dentro del area agro
            //print("Jugador cerca");
            cerca = true;

            if (heroeJugador.transform.position.x < this.transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);

            }
        }
        else
        {
            cerca = false;
        }

        if (cerca )
        {
            miCuerpo.velocity = this.transform.right * -velocidadCaminar;
            miAnimador.SetBool("Caminando", true);
        }
        else
        {
            miCuerpo.velocity = Vector3.zero;
            miAnimador.SetBool("Caminando", false);
        }
    }





    private void OnCollisionEnter2D(Collision2D collision) //Metodo para hacer da�o al enemigo
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player" && heroeJugador.GetComponent<Personaje>().muerto)
        {
            //print(name + "detecte colision con " + collision.gameObject);

            //Con esta instruccion se pbtiene el componente del Personaje Player
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            //con esta instruccion se hace 20 de da�o y digo quien realizo el da�o
            elPerso.hacerDanio(puntosDanio, gameObject);

        }
    }
}

