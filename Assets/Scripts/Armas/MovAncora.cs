using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovAncora : MonoBehaviour
{
    public float velocidade = 20f;
    public int dano = 1;
    public Rigidbody2D rb;
    public Animator efeitoDeDano;

    void OnTriggerEnter2D(Collider2D informacaoDano)
    {
        Kraken kraken = informacaoDano.GetComponent<Kraken>();
        Tentaculos tentaculo = informacaoDano.GetComponent<Tentaculos>();
        PeixeLanterna peixe = informacaoDano.GetComponent<PeixeLanterna>();
        
        if (kraken != null)
        {
            kraken.tomarDanoProjetil(dano);
        }
        Destroy(gameObject);
       
        if (tentaculo != null)
        {
            tentaculo.tomarDanoProjetil(dano);
        }
        Destroy(gameObject);

        if (peixe != null)
        {
            peixe.tomarDanoProjetil(dano);
        }
        Destroy(gameObject);


    }
}
