using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _settingMenu;
    [SerializeField] private GameObject _uiButton_menu;

    [SerializeField] private GameObject _uiButton_play;
    [SerializeField] private GameObject _uiButton_map;
    [SerializeField] private GameObject _uiButton_setting;
    [SerializeField] private GameObject _uiButton_quit;




    //public void StartGame()
    //{
    //SceneManager.LoadScene(1);
    //}

    //public void QuitGame()
    //{
    //Application.Quit();
    //}

    //public void Menu()
    //{
    //SceneManager.LoadScene(0);
    //ResumeButton();
    //}

    public void SettingButton()
    {
        Time.timeScale = 0f;
        //display settingMenu
        _settingMenu.SetActive(true);

        //hide menu button
        _uiButton_setting.SetActive(false);
        _uiButton_play.SetActive(false);
        _uiButton_map.SetActive(false);
        _uiButton_quit.SetActive(false);
    }

    public void GoBackToMenuButton()
    {
        Time.timeScale = 1.0f;
        _settingMenu.SetActive(false);

        //show menu button
        _uiButton_setting.SetActive(true);
        _uiButton_play.SetActive(true);
        _uiButton_map.SetActive(true);
        _uiButton_quit.SetActive(true);
    }
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
}

