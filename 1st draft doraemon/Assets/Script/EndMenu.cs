using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public TextMeshProUGUI score_text;
    void Start()
    {
        score_text.text = Score.CurScore.ToString();
    }
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
