using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Lives.CurLives = 3;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        //Lives.CurLives = 3;
    }

}
