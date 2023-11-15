using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadCaminar = 3f;
    public float fuerzaSalto = 50f;
    public bool enPiso = false;//Grounded
    public float saltosMax = 2f;
    public int DanioArma = 3;

    private Rigidbody2D miCuerpo;
    //private SpriteRenderer cavernicola;
    private Animator miAnimador;
    private float saltosRest;
    private ReproductorSonidos misSonidos;
    private Personaje miPersonaje;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
       // cavernicola = GetComponent<SpriteRenderer>();
        miAnimador = GetComponent<Animator>();
        saltosRest = saltosMax;
        misSonidos = GetComponent<ReproductorSonidos>();
        miPersonaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        //La comprobacion de piso
        //es lo primero que hace
        comprobarPiso();

        float velActualVert = miCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0 && !miPersonaje.aturdido)//a la derecha
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = false;
            miAnimador.SetBool("caminando", true);
        }
        else if (movHoriz < 0 && !miPersonaje.aturdido)//a la izquierda
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = true;
            miAnimador.SetBool("caminando", true);
        }

        else
        {
            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("caminando", false);
        }

        if (enPiso)
        {
            saltosRest = saltosMax;
            miAnimador.SetBool("en_piso", true);
        }
        else if (enPiso==false)
        {
            miAnimador.SetBool("en_piso", false);
        }

        if (Input.GetButtonDown("Jump") && saltosRest > 0 && !miPersonaje.aturdido) 
        {
            saltosRest--;
            miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
            miAnimador.SetBool("en_piso", false);
            misSonidos.reproducir("SALTAR");
        }
          
        if(Input.GetButtonDown("Fire1") && !miPersonaje.aturdido)
        {//atacar
            miAnimador.SetTrigger("Ataca");
        }
        




        miAnimador.SetFloat("vel_vert", velActualVert);
       
  }
    public void comprobarPiso()
        {

            //Lanzar rayo de deteccion de colisiones
            //hacia abajo desde la posicion del este objeto
            //(cavernicola)
            enPiso = Physics2D.Raycast(
            transform.position,//desde donde
            Vector2.down,//hacia abajo
            0.1f);//distancia
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        print(name + "hizo colision con" + col.gameObject.name);
        GameObject otro = col.gameObject;
        if (otro.tag == "Enemigo")
        {
            //Accede al componente de tipo Personaje del objeto con el que choquè
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando el metodo hacer daño
            elPerso.hacerDanio(DanioArma, this.gameObject);
            
            



        }
    }
}
