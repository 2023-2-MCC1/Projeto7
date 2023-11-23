using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilHydra : MonoBehaviour
{
    public int vidaProjetil = 5;
    public int dano;
    public VidaJogador vidaJogador;
    public AudioSource SomDeDano;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Jogador")
        {
        other.gameObject.GetComponent<VidaJogador>().TomarDano(dano);
        }
    }
    public void tomarDanoProjetil(int dano)
    {
        vidaProjetil -= dano;
        SomDeDano.Play();
    }
    void Update()
    {
        if (vidaProjetil <= 0)
        {
            Morte();
        }

    }

    void Morte()
    {
        Destroy(gameObject);
    }

}