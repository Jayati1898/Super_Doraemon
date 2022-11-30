using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    private static BackGroundMusic backgroundMusic;
    void Awake()
    {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
