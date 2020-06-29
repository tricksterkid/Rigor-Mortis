using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    public GameObject monster;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            monster.SetActive(false);
        }
    }
}
