using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doraemon : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    private GameObject[] Passport_Left;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Doraemon_blue();
    }

    // Update is called once per frame
    void Update()
    {
        Passport_Left = GameObject.FindGameObjectsWithTag("passport");
        if (Passport_Left.Length == 2 || Passport_Left.Length == 3)
        {
            Doraemon_red();
        }
        else if (Passport_Left.Length == 1)
        {
            Doraemon_less_red();
        }
        else if (Passport_Left.Length == 0)
        {
            Doraemon_blue();
        }
    }

    void Doraemon_red()
    {
        spriteRenderer.sprite = spriteArray[0];
    }

    void Doraemon_less_red()
    {
        spriteRenderer.sprite = spriteArray[1];
    }

    void Doraemon_blue()
    {
        spriteRenderer.sprite = spriteArray[2];
    }
}
