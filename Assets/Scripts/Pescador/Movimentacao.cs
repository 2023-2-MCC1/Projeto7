using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade;
    public GameObject objetoJogador;
    void Update()
    {
       //movimento esquerda
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
          
          transform.Translate(Vector2.left * Time.deltaTime * velocidade);
          //transform.localScale = new Vector3(-108, 108, 108);
        }
       //movimento direita 
        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
          transform.Translate(Vector2.right * Time.deltaTime * velocidade);
          //transform.localScale = new Vector3(108, 108, 108);
        }

    }
}   



