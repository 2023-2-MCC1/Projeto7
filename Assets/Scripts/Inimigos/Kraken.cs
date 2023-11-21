using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kraken : MonoBehaviour
{
    public int dano;
    public VidaJogador vidaJogador;
    public Rigidbody2D rb;
    public Slider barraDeVida;
    public int vidaKraken;
    
    public GameObject efeitoDeMorte;
    public GameObject TelaFinal;
    public Animator movKraken;

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
        vidaKraken -= dano;
        SomDeDano.Play();
    } 

    void Update()
    {
        
        barraDeVida.value = vidaKraken;
        
        if (vidaKraken <= 15)
        {
            Fase2();
        }
        
        if (vidaKraken <= 0)
        {
            Morte();
            somDeMorte.Play();
            
        }

    }
    void Fase2()
    {
       movKraken.Play("krakenMovimentacao");
    }
    
    void Morte()
    {
      
        efeitoDeMorte.SetActive(true);
        Instantiate(efeitoDeMorte, transform.position, Quaternion.identity);
        Destroy(gameObject);
        TelaFinal.SetActive(true);
    }

}
