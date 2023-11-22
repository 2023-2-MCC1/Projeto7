using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arpao : MonoBehaviour
{
    public Transform pontoDeTiro;
    public GameObject projetilPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Atirar();
        }
    }

    //lógica de tiro
    void Atirar()
    {
        Instantiate(projetilPrefab, pontoDeTiro.position, pontoDeTiro.rotation);
    }
}
