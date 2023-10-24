using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public InputField inputName;
    public Text displayName;
    public string playerName;

    public void changePlayername()
    {
        displayName.text = "Player: " + inputName.text; 
        MainManager.Instance.playername = inputName.text;
    }
    
    public void LoadGame()
    {
        playerName = inputName.text;
        Debug.Log(playerName);
        
        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
