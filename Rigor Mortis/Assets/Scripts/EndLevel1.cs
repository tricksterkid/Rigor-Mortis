using UnityEngine;

public class EndLevel1 : MonoBehaviour
{
    public GameObject victory;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            victory.SetActive(true);
            player.SetActive(false);
        }
    }
}