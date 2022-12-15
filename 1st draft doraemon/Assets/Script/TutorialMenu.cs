using Autodesk.Fbx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMenu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _tutorial_one_menu;
    [SerializeField] private GameObject _tutorial_two_menu;
    [SerializeField] private GameObject _tutorial_three_menu;

    [SerializeField] private GameObject _uiButton_left;
    [SerializeField] private GameObject _uiButton_right;
    [SerializeField] private GameObject _uiButton_jump;
    [SerializeField] private GameObject _uiButton_pause;
    [SerializeField] private GameObject _uiCurrent_live;


    private void Start()
    {

        if(Tutorial_on_off.CurTutorial == 1)
        {
            //turn off game scene button
            //Time.timeScale = 0f;
            _uiButton_right.SetActive(false);
            _uiButton_left.SetActive(false);
            _uiButton_jump.SetActive(false);
            _uiButton_pause.SetActive(false);
            _uiCurrent_live.SetActive(false);

            //turn on tutorial
            _tutorial_one_menu.SetActive(true);
            _tutorial_two_menu.SetActive(false);
            _tutorial_three_menu.SetActive(false);
        }
        else if(Tutorial_on_off.CurTutorial == 0)
        {
            //turn on game scene button
            //Time.timeScale = 0f;
            _uiButton_right.SetActive(true);
            _uiButton_left.SetActive(true);
            _uiButton_jump.SetActive(true);
            _uiButton_pause.SetActive(true);
            _uiCurrent_live.SetActive(true);

            //turn off tutorial
            _tutorial_one_menu.SetActive(false);
            _tutorial_two_menu.SetActive(false);
            _tutorial_three_menu.SetActive(false);
        }     
    }


    public void NextButton_One()
    {
        Time.timeScale = 0f;
        //display page two
        _tutorial_two_menu.SetActive(true);
        _tutorial_one_menu.SetActive(false);

        //hide menu button
        //_uiButton_right.SetActive(false);
        //_uiButton_left.SetActive(false);
        //_uiButton_jump.SetActive(false);
        //_uiButton_pause.SetActive(false);

        //_uiCurrent_live.SetActive(false);
    }

    public void NextButton_Two()
    {
        Time.timeScale = 0f;
        //display page three
        _tutorial_three_menu.SetActive(true);
        _tutorial_two_menu.SetActive(false);

        //hide menu button
        //_uiButton_right.SetActive(false);
        //_uiButton_left.SetActive(false);
        //_uiButton_jump.SetActive(false);
        //_uiButton_pause.SetActive(false);

        //_uiCurrent_live.SetActive(false);
    }

    public void Backward_Button_One()
    {
        Time.timeScale = 0f;
        //display page one
        _tutorial_one_menu.SetActive(true);
        _tutorial_two_menu.SetActive(false);

        //hide menu button
        //_uiButton_right.SetActive(false);
        //_uiButton_left.SetActive(false);
        //_uiButton_jump.SetActive(false);
        //_uiButton_pause.SetActive(false);

        //_uiCurrent_live.SetActive(false);
    }

    public void Backward_Button_Two()
    {
        Time.timeScale = 0f;
        //display page two
        _tutorial_two_menu.SetActive(true);
        _tutorial_three_menu.SetActive(false);

        //hide menu button
        //_uiButton_right.SetActive(false);
        //_uiButton_left.SetActive(false);
        //_uiButton_jump.SetActive(false);
        //_uiButton_pause.SetActive(false);

        //_uiCurrent_live.SetActive(false);
    }

    public void SkipButton()
    {
        //turn off tutorial 
        Time.timeScale = 1.0f;
        _tutorial_one_menu.SetActive(false);
        _tutorial_two_menu.SetActive(false);
        _tutorial_three_menu.SetActive(false);

        //show game scene button
        _uiButton_right.SetActive(true);
        _uiButton_left.SetActive(true);
        _uiButton_jump.SetActive(true);
        _uiButton_pause.SetActive(true);
        _uiCurrent_live.SetActive(true);
    }
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
}
