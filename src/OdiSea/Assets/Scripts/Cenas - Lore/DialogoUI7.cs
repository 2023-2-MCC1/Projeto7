using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoUI7 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Sensibilizado pelo sofrimento das criaturas aqu�ticas, Ant�nio abandona suas redes de pesca e se torna um defensor apaixonado da preserva��o marinha.", textLabel);
    }
}
