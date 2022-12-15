using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillEnemy : MonoBehaviour
{
    private Rigidbody2D rb;
    //public TextMeshProUGUI curren_lives_text;
    //private Animator anim;

    //[SerializeField] private AudioSource deathSoundEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        //curren_lives_text.text = "current lives: " + Lives.CurLives;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Trap"))
        {
            if (Lives.CurLives > 1)
            {
                Lives.CurLives--;
                Die_restart();
                //curren_lives_text.text = "current lives: " + Lives.CurLives;
            }
            else
            {
                Die_lose();
               //Lives.CurLives = 3;
            }
        }
    }

    private void Die_restart()
    {
        //deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");
        RestartLevel();
    }

    private void Die_lose()
    {
        //deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");
        LoseLevel();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void LoseLevel()
    {
        SceneManager.LoadScene(6);
    }
}
