using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public GameObject celebrationPrefab;
    private ReproductorSonidos misSonidos;
    private Animator miAnimador;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject otro = col.gameObject;
        if (otro.tag == "Player")
        {
            misSonidos.reproducir("CELEBRATION");
            GameObject celebracion = Instantiate(celebrationPrefab);
            celebracion.transform.position = this.transform.position;
            Personaje elPerso = otro.GetComponent<Personaje>();
            elPerso.festejar(this.gameObject);
            Invoke("siguienteEscena", 6f);
        }
    }

    private void siguienteEscena()
    {
        SceneManager.LoadScene("Expansion");
    }
}