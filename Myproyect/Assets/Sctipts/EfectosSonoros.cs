using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EfectosSonoros : MonoBehaviour
{
    public Efecto[] MisEfectos;

    [Serializable]

    public class Efecto
    {
        public string accion;
        public AudioClip sonido;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
