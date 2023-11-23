using UnityEngine;
using TMPro;

public class DialogoUI5 : MonoBehaviour
{
    [SerializeField] private TMP_Text textLabel;
    private void Start()
    {
        GetComponent<EfeitoDatilografado>().Run(textToType: "O vazamento transforma as pacíficas criaturas aquáticas em verdadeiros monstros, aterrorizando a cidade e ameaçando a sobrevivência de todos!", textLabel);
    }

}
