using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class HorizontalMovement : MonoBehaviour

{

    public float speed = 5.0f; // Velocidade de movimento 

    public float minX = -12.3f; // Limite m�nimo no eixo x 

    public float maxX = 8.5f;  // Limite m�ximo no eixo x 



    void Update()

    {

        // Obt�m o movimento horizontal (por exemplo, usando as teclas A e D ou as setas esquerda e direita) 

        float horizontalInput = Input.GetAxis("Horizontal");



        // Move o objeto horizontalmente 

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);



        // Garante que o objeto n�o passe dos limites 

        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);

        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);

    }

}

