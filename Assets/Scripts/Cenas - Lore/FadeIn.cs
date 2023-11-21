using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public GameObject fadeIn;
    public Animator fadein;


    private void Start()
    {
        fadein = GetComponent<Animator>();
        fadein.Play("FadeIn");
        Invoke("DesativarObjeto", fadein.GetCurrentAnimatorStateInfo(0).length);
    }

    private void DesativarObjeto()
    {
        fadeIn.SetActive(false);
    }
}

