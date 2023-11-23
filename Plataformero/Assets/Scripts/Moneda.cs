using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int valorMoneda = 10;
    private Animator  miAnimador;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(name + "hizo colision con" + collision.gameObject.name);
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accede al componente de tipo Personaje del objeto con el que choquè
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando el metodo hacer daño
            elPerso.score = elPerso.score + valorMoneda;
            miAnimador.SetTrigger("desaparecer");
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject,1.5f);
        }
    }

}
