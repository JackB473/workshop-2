using UnityEngine;

public class växtFlip : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        // Hitta palmens bild
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Vänd palmen fram och tillbaka
        if (Time.time % 2 < 1)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
} 


