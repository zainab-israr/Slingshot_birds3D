using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void newGame()
    {
        SceneManager.LoadScene("Start");
    }
    public void settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void levels()
    {
        SceneManager.LoadScene("Levels");
    }
    
    public void score()
    {
        SceneManager.LoadScene("Highscore");
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

