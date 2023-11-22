using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesMenu: MonoBehaviour
{
    public void jogar()
    {
        SceneManager.LoadScene(1);
    }
    public void creditos()
    {
        SceneManager.LoadScene(10);
    }
    public void sair()
    {
        Application.Quit();
    }
}
