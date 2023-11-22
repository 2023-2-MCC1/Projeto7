using UnityEngine;



public class Barreira1 : MonoBehaviour

{

    private void OnTriggerEnter2D(Collider2D other)

    {

        Destroy(other.gameObject); // Destroys the object that enters the trigger 

    }

}

