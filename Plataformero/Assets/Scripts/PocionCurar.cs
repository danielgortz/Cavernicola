using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionCurar : MonoBehaviour
{
    private Animator miAnimador;
    public int curarPuntos = 20;
    public Personaje heroe;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D curar)
    {
        PocionCurar pocion = GetComponent<PocionCurar>();
        print(name + "hizo colision con" + curar.gameObject.name);
        GameObject otro = curar.gameObject;
        if (otro.tag == "Player" && heroe.hp < 80)
        {
            miAnimador.SetTrigger("OBTENER");
            heroe.hp = heroe.hp + curarPuntos;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 1);
        }
    }
}
