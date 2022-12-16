using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;


public class HeartManager : MonoBehaviour
{
    [SerializeField] Image Three_Lives;
    [SerializeField] Image Two_Lives;
    [SerializeField] Image One_Lives;
    [SerializeField] Image Zero_Lives;

    // Start is called before the first frame update
    void Update()
    {
        if (Lives.CurLives == 3)
        {
            Three_Lives.enabled = true;
            Two_Lives.enabled = false;
            One_Lives.enabled = false;
            Zero_Lives.enabled = false;
        }
        else if(Lives.CurLives == 2)
        {
            Three_Lives.enabled = false;
            Two_Lives.enabled = true;
            One_Lives.enabled = false;
            Zero_Lives.enabled = false;
        }
        else if (Lives.CurLives == 1)
        {
            Three_Lives.enabled = false;
            Two_Lives.enabled = false;
            One_Lives.enabled = true;
            Zero_Lives.enabled = false;
        }
        else if (Lives.CurLives == 0)
        {
            Three_Lives.enabled = false;
            Two_Lives.enabled = false;
            One_Lives.enabled = false;
            Zero_Lives.enabled = true;
        }
    }
}
