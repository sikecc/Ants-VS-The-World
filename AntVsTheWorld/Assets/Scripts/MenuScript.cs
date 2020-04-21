using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void openIntro()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("ForestScene");
    }

    public void openTutorial()
    {
        SceneManager.LoadScene("Tutorial");
        
    }
    public void quit()
    {
        Debug.Log("Player has quit the game");
        Application.Quit();
    }
}
