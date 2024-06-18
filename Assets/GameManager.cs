using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    public void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }

    public void Exit()
    {
        //  Application.Quit();

        #if UNITY_STANDALONE
                        Application.Quit();
        #endif
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
