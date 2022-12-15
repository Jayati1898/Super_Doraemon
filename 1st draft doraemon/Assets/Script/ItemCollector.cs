using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemCollector : MonoBehaviour
{
    private int pineapple_bun = 0;

    //public GameObject pineapple_bun_OBJ;
    public TextMeshProUGUI pineapple_bun_text;

    [SerializeField] private AudioSource collectionSoundEffect;

    //void Start()
    //{
        //pineapple_bun_text = GetComponent<>;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("item collectable"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            pineapple_bun++;
            pineapple_bun_text.text = "pineapple bun: " + pineapple_bun;
            Score.CurScore = Score.CurScore + pineapple_bun;
        }
        else if (collision.gameObject.CompareTag("Heart"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            if (Lives.CurLives < 3)
            {
                Lives.CurLives++;
            }
        }
    }
}