using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tentaculos: MonoBehaviour
{
    public Slider barraDeVida;
    public int vidaTentaculo = 5;
    public int dano;
    public VidaJogador vidaJogador;
    public AudioSource SomDeDano;

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jogador"))
        {
            // Verifica se a colisão é com o jogador
            VidaJogador2 vidaDoJogador = other.GetComponent<VidaJogador2>();

            if (vidaDoJogador != null)
            {
                // Causa dano ao jogador
                vidaDoJogador.TomarDanoInimigo(dano);
            }
        }
    }*/
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jogador")
        {
            vidaJogador.TomarDano(dano);
        }
    }
    public void tomarDanoProjetil(int dano)
    {
        vidaTentaculo -= dano;
        SomDeDano.Play();
    }
    void Update()
    {
        barraDeVida.value = vidaTentaculo;
        
        if (vidaTentaculo <= 0)
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
