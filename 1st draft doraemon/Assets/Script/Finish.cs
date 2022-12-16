using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = false;

    private int sceneID;

    public GameObject passport;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
        sceneID = SceneManager.GetActiveScene().buildIndex;
        if (sceneID == 3)
        {
            passport = GameObject.FindGameObjectWithTag("passport");
            if(passport == null)
            {
                SceneManager.LoadScene(4);
            }
            //SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(5);
        }
    }
}
