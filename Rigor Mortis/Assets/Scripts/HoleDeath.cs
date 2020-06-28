using UnityEngine;

public class HoleDeath : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.SetActive(false);
            gameOver.SetActive(true);
        }
    }
}
