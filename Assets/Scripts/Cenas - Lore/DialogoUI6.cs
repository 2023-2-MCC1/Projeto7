using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoUI6 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Com coragem e habilidade, Ant�nio enfrenta os monstros aqu�ticos, protegendo sua cidade e restaurando a paz!!!", textLabel);
    }
}
