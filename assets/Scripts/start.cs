using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Background");
    }

    public void Facebook()
    {
        SceneManager.LoadScene("fb");
    }

    public void AgainPlayGame()
    {
        GameManager.Totalscore = 0;
        SceneManager.LoadScene("Start");
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
