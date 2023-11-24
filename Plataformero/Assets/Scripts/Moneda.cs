using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
   

    private Animator miAnimador;
    public float monedas = 0;
    public Personaje heroe;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D agarrar)
    {
        Moneda moneda = GetComponent<Moneda>();
        print(name + "hizo colision con" + agarrar.gameObject.name);
        GameObject otro = agarrar.gameObject;
        if (otro.tag == "Player")
        {
            miAnimador.SetTrigger("OBTENER");
            heroe.score++;
            monedas++;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 2);
        }
    }
}