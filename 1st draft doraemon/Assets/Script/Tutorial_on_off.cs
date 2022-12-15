using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_on_off : MonoBehaviour
{
    private static int m_InitialTutorial = 1;
    private static int m_CurTutorial;
    // static constructor
    static Tutorial_on_off()
    {
        m_CurTutorial = PlayerPrefs.GetInt("tutorial_on_off", m_InitialTutorial);
    }
    public static int CurTutorial
    {
        get { return m_CurTutorial; }
        set
        {
            m_CurTutorial = Mathf.Max(0, value); // clamp so it can't get negative
            PlayerPrefs.SetInt("tutorial_on_off", m_CurTutorial);
        }
    }
}
