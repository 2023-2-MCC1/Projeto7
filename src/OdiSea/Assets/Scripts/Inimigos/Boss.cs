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
    public float fireRate = 1.0f; // Intervalo em segundos entre cada proj�til
    public float bulletSpeed = 10f; // Velocidade do proj�til

    private float nextFireTime = 0f; // Quando o pr�ximo proj�til pode ser disparado
    private Transform target; // Refer�ncia para o alvo
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
            // Fa�a algo se o jogador n�o for encontrado
            UnityEngine.Debug.LogError("Player not found!");
        }
    }

    private void Update()
    {
        // Verifique se � o momento adequado para atirar
        if (Time.time >= nextFireTime)
        {
            // Atualize o pr�ximo tempo permitido para disparar
            nextFireTime = Time.time + 1f / fireRate;
            // Chame a fun��o de atirar
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
            // Obtenha a dire��o normalizada apontando para o alvo
            Vector2 directionToTarget = (target.position - pontoDeTiro.position).normalized;

            // Calcule o �ngulo em radianos
            float angle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;

            // Crie uma rota��o que apontar� para o alvo, considerando o sprite apontando para baixo
            Quaternion bulletRotation = Quaternion.AngleAxis(angle - 260f, Vector3.forward);

            // Instancie o proj�til
            GameObject bullet = Instantiate(ProjetilPrefab, pontoDeTiro.position, bulletRotation);

            // Defina a dire��o e velocidade do proj�til
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
