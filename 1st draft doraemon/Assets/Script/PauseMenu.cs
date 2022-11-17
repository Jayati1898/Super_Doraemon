using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _uiButton_left;
    [SerializeField] private GameObject _uiButton_right;
    [SerializeField] private GameObject _uiButton_jump;
    [SerializeField] private GameObject _pausebutton;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        ResumeButton();
    }

    public void PauseButton()
    {
        Time.timeScale = 0f;
        _pauseMenu.SetActive(true);
        _pausebutton.SetActive(false);

        //hide mobile controller button
        _uiButton_left.SetActive(false);
        _uiButton_right.SetActive(false);
        _uiButton_jump.SetActive(false);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1.0f;
        _pauseMenu.SetActive(false);
        _pausebutton.SetActive(true);

        //show mobile controller button
        _uiButton_left.SetActive(true);
        _uiButton_right.SetActive(true);
        _uiButton_jump.SetActive(true);
    }
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
}

