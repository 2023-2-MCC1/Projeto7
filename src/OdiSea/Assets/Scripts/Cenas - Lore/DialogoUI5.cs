using UnityEngine;
using TMPro;

public class DialogoUI5 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "O vazamento transforma as pac�ficas criaturas aqu�ticas em verdadeiros monstros, aterrorizando a cidade e amea�ando a sobreviv�ncia de todos!", textLabel);
    }

}
