using System.Collections;
using UnityEngine;

public class EndingCutscene : MonoBehaviour
{
    public GameObject bigZombie;
    public GameObject player;
    public GameObject lights;
    public GameObject car;
    public GameObject victory;

    private Animation moveCar;

    void Start()
    {
        moveCar = car.GetComponent<Animation>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            bigZombie.SetActive(false);
            player.SetActive(false);

            StartCoroutine(Play());
        }
    }

    IEnumerator Play()
    {
        yield return new WaitForSeconds(1);
        lights.SetActive(true);
        yield return new WaitForSeconds(2);
        moveCar.Play("MoveCar");
        yield return new WaitForSeconds(3);
        victory.SetActive(true);
    }
}
