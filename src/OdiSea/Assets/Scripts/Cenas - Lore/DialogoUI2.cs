using UnityEngine;
using TMPro;

public class DialogoUI2 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Senhor Antônio, um pescador local, dependia da vida na água para prover o sustento de sua família, sendo a pesca sua única fonte de renda.", textLabel);
    }

}