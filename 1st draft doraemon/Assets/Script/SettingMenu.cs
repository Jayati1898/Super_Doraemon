using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SettingMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _Menu;
    [SerializeField] private GameObject _settingMenu;
    [SerializeField] private GameObject _SettingButton;
    [SerializeField] private GameObject _GobackToMenuButton;

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
        _settingMenu.SetActive(true);
        _Menu.SetActive(false);
    }

    public void GoBackToMenuButton()
    {
        Time.timeScale = 1.0f;
        _settingMenu.SetActive(false);
        _Menu.SetActive(true);
    }
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
}
