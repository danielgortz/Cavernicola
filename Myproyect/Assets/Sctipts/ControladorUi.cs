using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUi : MonoBehaviour
{
    public Personaje heroe;
    public Text etiquetaHPHeroe;
    public Image barraHPHeroe;
    public Text etiquetaScore;             
    public Image corazon;
    public Text etiquetaVidas;
    // Update is called once per frame
    void Update()
    {
        etiquetaHPHeroe.text =
             heroe.hp + "/" + heroe.hpMax;

        float porcentajeHp =
            heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHp;

        etiquetaScore.text = "Score: " + heroe.score.ToString(); 
        etiquetaVidas.text = "x" + heroe.vidas;
    }
}
