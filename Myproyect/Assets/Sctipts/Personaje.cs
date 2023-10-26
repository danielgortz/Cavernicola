using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public int vidas = 3;
    private Animator miAnimador;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }
    public void hacerDanio(int puntos, GameObject atacante)
    {
        print(name + "recibe daño de " + puntos + "por" + atacante.name);
        hp = hp - puntos;
        miAnimador.SetTrigger("DAÑAR");
    }
    public void perderVida(int puntosVida, GameObject atacante)
    {
        print(name + "Muere por " + atacante.name);
        vidas = vidas - puntosVida;
       hp=0;
    }
}