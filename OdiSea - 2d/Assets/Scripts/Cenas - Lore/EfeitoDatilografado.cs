using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class EfeitoDatilografado : MonoBehaviour
{
    //fonte: www.youtube.com/watch?v=RfLCzDzkvb0

    [SerializeField] private float velocidade = 0f;
    public Coroutine Run(string textToType, TMP_Text textLabel)
    {
        return StartCoroutine(TypeText(textToType, textLabel));
    }

    private IEnumerator TypeText(string textToType, TMP_Text textLabel)
    {
        textLabel.text = string.Empty;
        
        yield return new WaitForSeconds(2);

        float t = 0;
        int charIndex = 0;

        while(charIndex < textToType.Length)
        {
            t += Time.deltaTime * velocidade;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            textLabel.text = textToType.Substring(0, charIndex);

            yield return null;

        }
        textLabel.text = textToType;
    }
}
