using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sereia: MonoBehaviour
{
    public int dano;
    public VidaJogador vidaJogador;

    public Slider barraDeVida;
    public int vidaSereia = 30;

    public GameObject efeitoDeMorte;
    //public Animator movSereia;

    public AudioSource SomDeDano;
    public AudioSource somDanoPescador;
    public AudioSource musicaSereia;


    void Start()
    {
        musicaSereia.Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jogador")
        {
            vidaJogador.TomarDano(dano);
            somDanoPescador.Play();
        }
    }
    public void tomarDano(int dano)
    {
        vidaSereia -= dano;
        SomDeDano.Play();
    }
    void Update()
    {

        barraDeVida.value = vidaSereia;

        //if (vidaSereia <= 15)
        //{
        //    Fase2();
        //}

        if (vidaSereia <= 0)
        {
            Morte();
        }


    }

    //void Fase2()
    //{
    //    movSereia.Play("sereiaMovimentacao");
    //}
    void Morte()
    {
        efeitoDeMorte.SetActive(true);
        Instantiate(efeitoDeMorte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


}
