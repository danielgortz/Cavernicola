using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cofre : MonoBehaviour
{
    private Animator miAnimador;
    public GameObject tesoro;
    public bool cercaCofre = false;
    public GameObject boton;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2") && cercaCofre)
        {
            miAnimador.SetTrigger("OBTENER");
            Instantiate(tesoro, transform.position, Quaternion.identity);
        }

    }
    private void OnTriggerEnter2D(Collider2D abrir)
    {

        Cofre cofre = GetComponent<Cofre>();
        print(name + "hizo colision con" + abrir.gameObject.name);
        GameObject otro = abrir.gameObject;

        if (otro.tag == "Player")
        {
            cercaCofre = true;
            boton.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D fuera)
    {

        Cofre cofre = GetComponent<Cofre>();
        print(name + "salio de" + fuera.gameObject.name);
        GameObject otro = fuera.gameObject;

        if (otro.tag == "Player")
        {
            cercaCofre = true;
            boton.SetActive(true);
        }
    }
}