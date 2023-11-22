using UnityEngine;
using TMPro;

public class DialogoUI3 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Certo dia, a empresa multinacional 'ÁguasLimpas' chega à cidade, prometendo melhorar a qualidade de vida da comunidade. Porém, algo se esconde por trás dessa aparente benevolência...", textLabel);
    }

}
