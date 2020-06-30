using System.Collections;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject ui;
    public GameObject collider;

    void Start()
    {
        StartCoroutine(Go());
    }

    IEnumerator Go()
    {
        yield return new WaitForSeconds(3);
        cam2.SetActive(false);
        collider.SetActive(false);
        cam1.SetActive(true);
        ui.SetActive(true);
    }
}
