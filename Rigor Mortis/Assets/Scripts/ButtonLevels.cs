using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevels : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level02");
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level03");
    }
}
