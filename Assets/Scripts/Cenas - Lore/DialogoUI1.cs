using UnityEngine;
using TMPro;

public class DialogoUI1 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Numa pequena cidade ribeirinha, a exist�ncia dos moradores estava inteiramente ligada aos seres vivos que habitavam as �guas locais, sua fonte de vida e sustento.", textLabel);

    }

}
