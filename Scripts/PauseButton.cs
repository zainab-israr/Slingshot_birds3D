using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameIsResumed = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
   
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameIsResumed = true;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        //freeze time
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;   
    }
}
