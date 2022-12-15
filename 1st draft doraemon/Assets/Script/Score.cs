using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static int m_InitialScore = 3;
    private static int m_CurScore;
    // static constructor
    static Score()
    {
        m_CurScore = PlayerPrefs.GetInt("Score", m_InitialScore);
    }
    public static int CurScore
    {
        get { return m_CurScore; }
        set
        {
            m_CurScore = Mathf.Max(0, value); // clamp so it can't get negative
            PlayerPrefs.SetInt("Score", m_CurScore);
        }
    }
}
