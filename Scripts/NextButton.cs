using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public void LoadNextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;           

        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);
        }

        SceneManager.LoadScene($"Level {currentLevel + 1}");

        //Debug.Log("Level" + PlayerPrefs.GetInt("levelsUnlocked") + " Unlocked!");
    }
}
