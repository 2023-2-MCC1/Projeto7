using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Movimento : MonoBehaviour

{

    public float velocidade = 1.0f; // Ajuste a velocidade 

    public float raioX = 6.0f; // Raio no eixo X 

    public float raioY = 3.0f; // Raio no eixo Y 

    private float angulo = -Mathf.PI / 2; // Inicia no ponto mais baixo de Y 



    void Update()

    {

        // Calcula a posi��o com base no tempo 

        float posX = raioX * Mathf.Cos(angulo);

        float posY = raioY * Mathf.Sin(angulo);



        // Atualiza a posi��o do objeto 

        transform.position = new Vector2(posX, posY);



        // Incrementa o �ngulo para fazer se mover 

        angulo += velocidade * Time.deltaTime;



        // Normaliza o �ngulo para evitar overflow 

        if (angulo > 2 * Mathf.PI)

        {

            angulo -= 2 * Mathf.PI;

        }

        else if (angulo < -2 * Mathf.PI)

        {

            angulo += 2 * Mathf.PI;

        }

    }

}

