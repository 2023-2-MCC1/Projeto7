using UnityEngine;
using TMPro;

public class DialogoUI3 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Certo dia, a empresa multinacional '�guasLimpas' chega � cidade, prometendo melhorar a qualidade de vida da comunidade. Por�m, algo se esconde por tr�s dessa aparente benevol�ncia...", textLabel);
    }

}
