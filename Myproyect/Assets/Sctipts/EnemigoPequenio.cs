using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPequenio : MonoBehaviour
{
    public float distanciaAgro = 5;
    private GameObject heroe;

    // Start is called before the first frame update
    void Start()
    {
        heroe = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        vector3 posHeroe = heroe.transform.position;
        vector3 posYo = this.transform.position;

        float distancia = (posYo - posHeroe).magnitude;
        if(distancia < distanciaAgro)
        {//el heroe esta fuera de la zona de agro
            if(posHeroe,x > posYo.x)
            {//el heroe esta a la derecha del villano

            }
             
             else
             {//el heroe esta fuera de la zona de agro
                transform.rotation = Quaternion.Euler(0, 180, 0);
             }
    
        }
    }     else
}
private void OnCollisionEnter2D(Collision2D collision)
{
    print(name + "hizo colision con" + collision.gameObject.name);
    GameObject otro = collision.gameObject;
    if (otro.tag == "Player")
    {
        //Accede al componente de tipo Personaje del objeto con el que choquè
        Personaje elPerso = otro.GetComponent<Personaje>();
        //Aplico el daño al otro invocando el metodo hacer daño
        elPerso.hacerDanio(puntosDanio, this.gameObject);
    }
}