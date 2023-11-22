using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tridente: MonoBehaviour
{
    public int vidaTridente = 5;
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
    public void tomarDanoProjetil (int dano)
    {
        vidaTridente -= dano;
        SomDeDano.Play();
    }
    void Update()
    {
        if (vidaTridente <= 0)
        {
            Morte();
        }

    }

    void Morte()
    {
        Destroy(gameObject);
    }
}
