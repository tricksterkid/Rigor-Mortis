using UnityEngine;

public class Pause : MonoBehaviour
{
    public void PauseGame()
    {
        Time.timeScale = 0.0f;
    }

    public void PlayGame()
    {
        Time.timeScale = 1.0f;
    }
}
