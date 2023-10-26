using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidadCaminar = 3f;
    public float fuerzaSalto = 50f;
    public bool enPiso = false;
    public float saltosMax = 2f;

    private Rigidbody2D miCuerpo;
    //private SpriteRenderer cavernicola;
    private Animator miAnimador;
    private float saltosRestantes;

    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        // cavernicola = GetComponent<SpriteRenderer>();
        miAnimador = GetComponent<Animator>();
        saltosRestantes = saltosMax; 
    }

    void Update()
    {
        //La comprobacion de piso
        //es lo primero que hace
        comprobarPiso();

        float velActualVert = miCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = false;
            miAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
            //cavernicola.flipX = true;
            miAnimador.SetBool("CAMINANDO", true);
        }

        else
        {
            miCuerpo.velocity = new Vector3(0, velActualVert, 0);
            miAnimador.SetBool("CAMINANDO", false);
        }

        if (enPiso)
        {
            saltosRestantes = saltosMax;
        }

        if (Input.GetButtonDown("Jump") && saltosRestantes > 0)
        {
            saltosRestantes--;
            miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
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
    
}