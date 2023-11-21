using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class VidaJogador : MonoBehaviour
{
    public int vidaMaxima = 10;
    public int vida;
    //public GameObject coracao1;
    //public GameObject coracao2;
    //public GameObject coracao3;
    void Start()
    {
        vida = vidaMaxima;
    }
    

    public void TomarDano(int dano)
    {
        vida -= dano;
        
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

}
