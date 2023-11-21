using UnityEngine;
using TMPro;

public class DialogoUI4 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "Subitamente... o navio principal da empresa sofre um ENORME VAZAMENTO de material radioativo, causando uma devastação na vida dos moradores, que agora enfrentam uma terrível ameaça!", textLabel);
    }

}
