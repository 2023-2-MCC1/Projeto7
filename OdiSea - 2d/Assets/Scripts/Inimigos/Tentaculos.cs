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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Jogador")
        {
            other.gameObject.GetComponent<VidaJogador>().TomarDano(dano);
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
