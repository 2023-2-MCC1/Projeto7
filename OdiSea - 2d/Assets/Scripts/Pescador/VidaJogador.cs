using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;


public class VidaJogador : MonoBehaviour
{
    public Slider barraDeVida;
    public int vidaMaxima = 10;
    public int vidaJogador = 10;
    public AudioSource hitJogador;

    void Start()
    {
        vidaJogador = vidaMaxima;

    }

    public void TomarDano(int dano)
    {
        vidaJogador -= dano;
        hitJogador.Play();



        if (vidaJogador <= 0)
        {
            Destroy(gameObject);

        }
    }

    void Update()
    {
        barraDeVida.value = vidaJogador;

        if (vidaJogador <= 0)
        {
            Morte();
        }

    }
    void Morte()
    {
        barraDeVida.gameObject.SetActive(false);
        Destroy(gameObject);
       

    }

    
         
             

}
