using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifeAndItemCollect : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;

    private int pineapple_bun = 0;

    public TextMeshProUGUI pineapple_bun_text;

    private int player_life = 3;

    public TextMeshProUGUI player_life_text;

    [SerializeField] private AudioSource collectionSoundEffect;

    Vector2 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag("Trap")) || (collision.gameObject.CompareTag("Enemy")))
        {
            if(player_life > 0)
            {
                player_life--;
                player_life_text.text = "Player HP: " + player_life;
                transform.position = startPosition;
            }
            else
            {
                Die_lost();
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

    private void Die_lost()
    {
        //deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");
        Lost();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Lost()
    {
        SceneManager.LoadScene(5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("item collectable"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            pineapple_bun++;
            pineapple_bun_text.text = "pineapple bun: " + pineapple_bun;
            if(pineapple_bun == 20)
            {
                player_life++;
                player_life_text.text = "player life: " + player_life;
            }
        }
    }
}
