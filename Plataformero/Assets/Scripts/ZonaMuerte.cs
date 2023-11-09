using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    public int puntosVida = 1;
    public GameObject efectoAguaPrefab;
    private ReproductorSonidos misSonidos;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        print(name + "hizo colision con" + col.gameObject.name);
        GameObject otro = col.gameObject;
        if (otro.tag == "Player")
        {
            //Accede al componente de tipo Personaje del objeto con el que choqu�
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el da�o al otro invocando el metodo hacer da�o
            elPerso.matar(puntosVida, this.gameObject);

            GameObject agua = Instantiate(efectoAguaPrefab, elPerso.transform);
            misSonidos.reproducir("SPLASH");
        }
    }
}
