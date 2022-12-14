using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        Lives.CurLives = 3;
        SceneManager.LoadScene(1);
        //ResumeButton();
    }
}
