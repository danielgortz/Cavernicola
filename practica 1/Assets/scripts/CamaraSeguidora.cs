using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidora : MonoBehaviour
{
    //Este es un atributo de la clase
    //que funciona como referencia a
    //la pelota de la escena
    public Transform pelota;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Le coloco la posicion de la pelota
        //a la camara, exceptop en Z
        transform.position =
             new Vector3(
                 pelota.position.x,
                 pelota.position.y,
                 -1);
    }
}
