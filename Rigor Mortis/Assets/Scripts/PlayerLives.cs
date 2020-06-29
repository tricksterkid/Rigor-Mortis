using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public GameObject player;
    public GameObject gameOver;
    int deathCounter;

    private bool heart1IsOff = false;
    private bool heart2IsOff = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            deathCounter += 1;
            Debug.Log(deathCounter);
        }

        if (deathCounter == 1)
        {
            heart1.SetActive(false);
            heart1IsOff = true;
        }

        if (deathCounter == 2)
        {
            heart2.SetActive(false);
            heart2IsOff = true;
        }

        if (deathCounter == 3)
        {
            heart3.SetActive(false);
            player.SetActive(false);
            gameOver.SetActive(true);
        }

        if (other.gameObject.CompareTag("Heart"))
        {
            if (heart1IsOff == true && heart2IsOff == false)
            {
                deathCounter -= 1;
                Debug.Log(deathCounter);
                heart1.SetActive(true);
                heart1IsOff = false;
                other.gameObject.SetActive(false);
            }

            if (heart2IsOff == true && heart1IsOff == true)
            {
                deathCounter -= 1;
                Debug.Log(deathCounter);
                heart2.SetActive(true);
                heart2IsOff = false;
                other.gameObject.SetActive(false);
            }
        }
    }
}
