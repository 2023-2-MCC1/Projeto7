using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoUI9 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Senhor Antônio se torna o herói da cidade, unindo corações para revitalizar e proteger a vida nas águas! Rodeado por sorrisos, ele levanta uma bandeira e celebra a resiliência após todos os desafios!", textLabel);
    }
}
