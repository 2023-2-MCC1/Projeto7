using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void cena2()
    {
        SceneManager.LoadScene(2);
    }
    public void cena3()
    {
        SceneManager.LoadScene(3);
    }
    public void cena4()
    {
        SceneManager.LoadScene(4);
    }
    public void cena5()
    {
        SceneManager.LoadScene(5);
    }
    public void fasekraken()
    {
        SceneManager.LoadScene(8);

    }
    public void KrakenAbatido()
    {
        SceneManager.LoadScene(9);
    }

}
