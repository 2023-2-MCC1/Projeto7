using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoUI7 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Sensibilizado pelo sofrimento das criaturas aquáticas, Antônio abandona suas redes de pesca e se torna um defensor apaixonado da preservação marinha.", textLabel);
    }
}
