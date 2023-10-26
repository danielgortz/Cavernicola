using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            print("Se presionó salto");
            MiCuerpo.AddForce(
                new Vector3(0, 20, 0),
            ForceMode2D.Impulse);
        }
    }
}
