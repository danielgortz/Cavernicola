using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
    public bool aturdido = false;
    private Animator miAnimador;
    public GameObject efectoSangrePrefab;
    private ReproductorSonidos misSonidos;
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
    }

    private void desaturdir()
    {
        aturdido = false;
    }


    //public void matar()
    public void matar(int puntosVida, GameObject atacante)
    {
        print(name + "Muere por " + atacante.name);
        vidas = vidas - puntosVida;
        hp = 0;
        miAnimador.SetTrigger("MATAR");
        misSonidos.reproducir("MATAR");
    }
}
