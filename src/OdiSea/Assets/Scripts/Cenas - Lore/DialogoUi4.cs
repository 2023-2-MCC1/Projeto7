using UnityEngine;
using TMPro;

public class DialogoUI4 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Subitamente... o navio principal da empresa sofre um ENORME VAZAMENTO de material radioativo, causando uma devasta��o na vida dos moradores, que agora enfrentam uma terr�vel amea�a!", textLabel);
    }

}
