using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoUI6 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Com coragem e habilidade, Antônio enfrenta os monstros aquáticos, protegendo sua cidade e restaurando a paz!!!", textLabel);
    }
}
