using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeixeLanterna : MonoBehaviour
{
    public int dano;
    public VidaJogador vidaJogador;
    public Rigidbody2D rb;
    public Slider barraDeVida;
    public int vidaPeixe;

    public GameObject efeitoDeMorte;
    public GameObject TelaFinal;
    public Animator movPeixe;

    public AudioSource SomDeDano;
    public AudioSource somDanoPescador;
    public AudioSource somDeMorte;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jogador"))
        {

            if (vidaJogador != null)
            {
                vidaJogador.TomarDano(dano);
            }
        }
    }

    public void tomarDanoProjetil(int dano)
    {
        vidaPeixe -= dano;
        SomDeDano.Play();
    }

    void Update()
    {

        barraDeVida.value = vidaPeixe;

        if (vidaPeixe <= 20)
        {
            Fase2();
        }

        if (vidaPeixe <= 0)
        {
            Morte();
            somDeMorte.Play();

        }

    }
    void Fase2()
    {
        movPeixe.Play("peixeMovimentacao");
    }

    void Morte()
    {
        efeitoDeMorte.SetActive(true);
        Instantiate(efeitoDeMorte, transform.position, Quaternion.identity);
        Destroy(gameObject);
        TelaFinal.SetActive(true);
    }

}



