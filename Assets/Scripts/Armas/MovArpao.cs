using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovArpao : MonoBehaviour
{
    public float velocidade = 20f;
    public int dano = 1;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * velocidade;
    }

    void OnTriggerEnter2D(Collider2D informacaoDano)
    {
        Kraken kraken = informacaoDano.GetComponent<Kraken>();
        Tentaculos tentaculo = informacaoDano.GetComponent<Tentaculos>();
        PeixeLanterna peixe = informacaoDano.GetComponent<PeixeLanterna>();
        Sereia sereia = informacaoDano.GetComponent<Sereia>();
        Boss hydra = informacaoDano.GetComponent<Boss>();

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

        if (sereia != null)
        {
            sereia.tomarDanoProjetil(dano);
        }
        Destroy(gameObject);

        if (hydra != null)
        {
            hydra.tomarDanoProjetil(dano);
        }
        Destroy(gameObject);


    }
}
