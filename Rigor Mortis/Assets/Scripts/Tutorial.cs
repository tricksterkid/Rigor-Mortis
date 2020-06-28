using System.Collections;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject message1;
    public GameObject message2;
    public GameObject message3;
    public GameObject message4;
    public GameObject message5;

    void Start()
    {
        StartCoroutine(TutorialMessage());
    }

    IEnumerator TutorialMessage()
    {
        yield return new WaitForSeconds(2);
        message1.SetActive(true);
        yield return new WaitForSeconds(2);
        message1.SetActive(false);

        yield return new WaitForSeconds(2);
        message2.SetActive(true);
        yield return new WaitForSeconds(2);
        message2.SetActive(false);

        yield return new WaitForSeconds(2);
        message3.SetActive(true);
        yield return new WaitForSeconds(2);
        message3.SetActive(false);

        yield return new WaitForSeconds(2);
        message4.SetActive(true);
        yield return new WaitForSeconds(2);
        message4.SetActive(false);

        yield return new WaitForSeconds(2);
        message5.SetActive(true);
        yield return new WaitForSeconds(2);
        message5.SetActive(false);
    }
}
