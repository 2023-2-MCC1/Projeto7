using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoUI9 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Senhor Ant�nio se torna o her�i da cidade, unindo cora��es para revitalizar e proteger a vida nas �guas! Rodeado por sorrisos, ele levanta uma bandeira e celebra a resili�ncia ap�s todos os desafios!", textLabel);
    }
}
