using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sereia : MonoBehaviour
{
    public int dano;
    public VidaJogador vidaJogador;
    public Rigidbody2D rb;
    public Slider barraDeVida;
    public int vidaSereia;

    public GameObject efeitoDeMorte;
    public GameObject TelaFinal;
    public Animator movSereia;

    public AudioSource SomDeDano;
    public AudioSource somDanoPescador;
    public AudioSource somDeMorte;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jogador")
        {
            vidaJogador.TomarDano(dano);
            somDanoPescador.Play();
        }
    }
    public void tomarDanoProjetil(int dano)
    {
        vidaSereia -= dano;
        SomDeDano.Play();
    }

    void Update()
    {

        barraDeVida.value = vidaSereia;

        if (vidaSereia <= 15)
        {
            Fase2();
        }

        if (vidaSereia <= 0)
        {
            Morte();
            somDeMorte.Play();

        }

    }
    void Fase2()
    {
        movSereia.Play("sereia2");
    }
    void Morte()
    {
        efeitoDeMorte.SetActive(true);
        Instantiate(efeitoDeMorte, transform.position, Quaternion.identity);
        Destroy(gameObject);
        TelaFinal.SetActive(true);
    }
}

   
