using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public static int vidas = 3;
    private Animator miAnimador;
    public GameObject efectoSangrePrefab;
    private ReproductorSonidos misSonidos;
    public bool aturdido = false;
    public bool muerto = false;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();
    }
    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe daño de " + puntos + "por" + atacante.name);
        hp = hp - puntos;
        miAnimador.SetTrigger("DAÑAR");
        GameObject sangre = Instantiate(efectoSangrePrefab, transform);
        misSonidos.reproducir("DAÑAR");
        aturdido = true;
        Invoke("desaturdir", 1);
        if (hp <= 0 && vidas <= 0)
        {
            Personaje elPerso = GetComponent<Personaje>();
            elPerso.matar(this.gameObject);
        }
        if (hp <= 0 && vidas > 0)
        {
            vidas--;
            muerto = true;
        }

    }

    public void matar(GameObject atacante)
    {
        print(name + "Muere por " + atacante.name);
        vidas = 0;
        hp = 0;
        miAnimador.SetTrigger("MATAR");
        misSonidos.reproducir("MATAR");

        muerto = true;
    }
    private void desaturdir()
    {
        aturdido = false;
    }
    public bool gameOver()
    {
        return vidas <= 0;
    }
}