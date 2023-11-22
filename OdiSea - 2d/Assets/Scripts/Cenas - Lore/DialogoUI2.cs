using UnityEngine;
using TMPro;

public class DialogoUI2 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Senhor Ant�nio, um pescador local, dependia da vida na �gua para prover o sustento de sua fam�lia, sendo a pesca sua �nica fonte de renda.", textLabel);
    }

}