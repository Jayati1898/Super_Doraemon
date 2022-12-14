using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    private static int m_InitialLives = 3;
    private static int m_CurLives;
    // static constructor
    static Lives()
    {
        m_CurLives = PlayerPrefs.GetInt("lives", m_InitialLives);
    }
    public static int CurLives
    {
        get { return m_CurLives; }
        set
        {
            m_CurLives = Mathf.Max(0, value); // clamp so it can't get negative
            PlayerPrefs.SetInt("lives", m_CurLives);
        }
    }
}
