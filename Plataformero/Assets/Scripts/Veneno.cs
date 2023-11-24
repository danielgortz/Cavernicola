using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veneno : MonoBehaviour
{
    public Personaje heroe;
    public int puntosDanio = 5;
    public float repetirDanio = 2f;
    private Animator miAnimador;

    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D veneno)
    {
        Veneno pocionV = GetComponent<Veneno>();
        print(name + "hizo colision con" + veneno.gameObject.name);
        GameObject otro = veneno.gameObject;
        if (otro.tag == "Player")
        {
            InvokeRepeating("DanioRepeat", 0f, repetirDanio);
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 4f);
            miAnimador.SetTrigger("OBTENER");
        }
    }

    void DanioRepeat()
    {
        if (heroe != null)
        {
            heroe.hacerDanio(puntosDanio, this.gameObject);
        }
    }
}