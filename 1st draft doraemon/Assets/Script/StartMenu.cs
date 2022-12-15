using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        Lives.CurLives = 3;
        Score.CurScore = 0;
        Tutorial_on_off.CurTutorial = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Map()
    {
        SceneManager.LoadScene(5);
    }
}

