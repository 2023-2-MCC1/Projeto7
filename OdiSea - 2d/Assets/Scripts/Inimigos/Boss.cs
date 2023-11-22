using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public int dano;
    public Slider barraDeVida;
    public VidaJogador vidaJogador;
    public Rigidbody2D rb;
    public int vidaHydra;
    public GameObject TelaFinal;
    public Animator movHydra;

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
        vidaHydra -= dano;
        SomDeDano.Play();
    }

    void Update()
    {

        barraDeVida.value = vidaHydra;

        if (vidaHydra <= 15)
        {
            Fase2();
        }

        if (vidaHydra <= 0)
        {
            Morte();
            somDeMorte.Play();

        }

    }
    void Fase2()
    {
        movHydra.Play("hydraMovimentacao");
    }

    void Morte()
    {
        Destroy(gameObject);
        TelaFinal.SetActive(true);
    }



    /*
     
    public Transform pontoDeTiro;
    public GameObject ProjetilPrefab;
    public GameObject TelaFinal;
    public AudioSource SomDeDano;
    public int dano;
    public Player Player;
    public float fireRate = 1.0f; // Intervalo em segundos entre cada projétil
    public float bulletSpeed = 10f; // Velocidade do projétil

    private float nextFireTime = 0f; // Quando o próximo projétil pode ser disparado
    private Transform target; // Referência para o alvo
    public int vidaBoss = 25;

    private void Start()
    {
        // Exemplo: procurando um objeto com a tag "Player" para definir como alvo
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
        else
        {
            // Faça algo se o jogador não for encontrado
            UnityEngine.Debug.LogError("Player not found!");
        }
    }

    private void Update()
    {
        // Verifique se é o momento adequado para atirar
        if (Time.time >= nextFireTime)
        {
            // Atualize o próximo tempo permitido para disparar
            nextFireTime = Time.time + 1f / fireRate;
            // Chame a função de atirar
            Shoot();
        }
        if (vidaBoss <= 0)
        {
            TelaFinal.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void Shoot()
    {
        if (target != null)
        {
            // Obtenha a direção normalizada apontando para o alvo
            Vector2 directionToTarget = (target.position - pontoDeTiro.position).normalized;

            // Calcule o ângulo em radianos
            float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;

            // Crie uma rotação que apontará para o alvo, considerando o sprite apontando para baixo
            Quaternion bulletRotation = Quaternion.AngleAxis(angle - 260f, Vector3.forward);

            // Instancie o projétil
            GameObject bullet = Instantiate(ProjetilPrefab, pontoDeTiro.position, bulletRotation);

            // Defina a direção e velocidade do projétil
            bullet.GetComponent<Rigidbody2D>().velocity = directionToTarget * bulletSpeed; // use a velocidade configurada


        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.TomarDano(dano);
        }
    }

    public void tomarDanoProjetil(int dano)
    {
        vidaBoss -= dano;
        SomDeDano.Play();
    }


    */


}
