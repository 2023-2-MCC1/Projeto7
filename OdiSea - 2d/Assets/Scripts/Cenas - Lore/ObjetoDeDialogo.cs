using UnityEngine;

[CreateAssetMenu(menuName = "Dialogo/ObjetoDeDialogo")]

public class ObjetoDeDialogo : ScriptableObject
{
    [SerializeField][TextArea] private string[] dialogo;
    public string[] Dialogo => dialogo;

}
