using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inimigo : MonoBehaviour
{
    /*
    public Slider barraDeVida;
    public int vida = 40;
    public int dano;
    public Rigidbody2D rb;

    public VidaJogador vidaJogador;
    public GameObject efeitoDeMorte;
    public Animator movFase2;

    public AudioSource SomDeDano;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jogador")
        {
            vidaJogador.TomarDano(dano);
        }
    }
    public void tomarDanoProjetil(int dano)
    {
        vida -= dano;
        SomDeDano.Play();
    }
    void Update()
    {

        barraDeVida.value = vida;

        if (vida <= 30)
        {
            Fase2();
        }

        if (vida <= 0)
        {
            Morte();
        }


    }

    void Fase2()
    {
        movFase2.Play("peixeMovimentacao");
    }
    void Morte()
    {
        efeitoDeMorte.SetActive(true);
        Instantiate(efeitoDeMorte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    */
}
    
