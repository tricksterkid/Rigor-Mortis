using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public GameObject player;
    public GameObject gameOver;
    int deathCounter;

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
        }

        if (deathCounter == 2)
        {
            heart2.SetActive(false);
        }

        if (deathCounter == 3)
        {
            heart3.SetActive(false);
            player.SetActive(false);
            gameOver.SetActive(true);
        }
    }
}
