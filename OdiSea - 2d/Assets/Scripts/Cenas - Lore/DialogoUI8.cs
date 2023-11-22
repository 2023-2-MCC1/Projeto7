using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoUI8 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "A verdade sobre a corporaçào 'ÁguasLimpas' ganha luz, levando ao fechamento da empresa. Assim, leis ambientais mais rigorosas foram implementadas para proteger nossas águas.", textLabel);
    }
}
