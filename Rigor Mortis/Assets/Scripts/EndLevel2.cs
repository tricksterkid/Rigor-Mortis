using System.Collections;
using UnityEngine;

public class EndLevel2 : MonoBehaviour
{ 
    public GameObject p1;
    public GameObject p2;

    public GameObject victory;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            p2.SetActive(true);
            p1.SetActive(false);

            StartCoroutine(StopLevel());
        }

        IEnumerator StopLevel()
        {
            yield return new WaitForSeconds(3);
            victory.SetActive(true);
        }
    }
}
