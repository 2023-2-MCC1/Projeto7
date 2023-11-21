using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJogador2 : MonoBehaviour
{
    public int vidaMaxima = 100;
    private int vidaAtual;

    private void Start()
    {
        vidaAtual = vidaMaxima;
    }

    public void TomarDanoInimigo(int dano)
    {
        vidaAtual -= dano;
        // Exemplo: GetComponent<Animator>().SetTrigger("Machucar");

        if (vidaAtual <= 0)
        {
            Morrer();
        }
    }

    void Morrer()
    {
        Destroy(gameObject); // Faça algo quando o jogador morrer, como reiniciar o nível ou exibir uma tela de game over.
        // Exemplo: GerenciadorDeJogo.Instancia.GameOver();
    }
}
