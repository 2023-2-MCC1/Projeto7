using System.Diagnostics;
using UnityEngine;



public class Player : MonoBehaviour

{
    public int vidaMaxima = 3;
    public int vida;
    public Transform pontoDeTiro;
    public GameObject ProjetilPrefab;
    public float fireRate = 1.0f; // Interval in seconds between each projectile
    private float nextFireTime = 0f; // When the next projectile can be fired 



    private void Update()

    {

        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)

        {

            nextFireTime = Time.time + fireRate; // Set the next allowed fire time 

            Atirar();

        }

    }



    void Atirar()

    {
        Instantiate(ProjetilPrefab, pontoDeTiro.position, pontoDeTiro.rotation);

    }


    void Start()
    {
        vida = vidaMaxima;
    }


    public void TomarDano(int dano)
    {
        vida -= dano;

        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }


}

