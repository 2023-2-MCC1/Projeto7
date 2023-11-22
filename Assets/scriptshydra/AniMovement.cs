using UnityEngine;



public class ImageAnimator : MonoBehaviour

{

    public SpriteRenderer spriteRenderer; // Attach the GameObject's SpriteRenderer 

    public Sprite firstImage;             // Assign the first sprite in the Inspector 

    public Sprite secondImage;            // Assign the second sprite in the Inspector 

    public float switchInterval = 1.0f;   // Time in seconds between image switches 



    private float timer;                  // Internal timer 



    void Start()

    {

        timer = switchInterval;

    }



    void Update()

    {

        // Update the timer 

        timer -= Time.deltaTime;



        if (timer <= 0)

        {

            // Reset the timer 

            timer = switchInterval;



            // Switch the image 

            if (spriteRenderer.sprite == firstImage)

            {

                spriteRenderer.sprite = secondImage;

            }

            else

            {

                spriteRenderer.sprite = firstImage;

            }

        }

    }

}

