using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarMusica: MonoBehaviour
{
    public AudioSource musica;

    void Start()
    {
        musica.Play();
    }
    
}
