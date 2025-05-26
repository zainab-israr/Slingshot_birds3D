using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelsController : MonoBehaviour
{
    public Button[] buttons;
    int levelsUnlocked;
    // Start is called before the first frame update
    //use this for initialization
    void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked",1);
       
        for(int i=0;i<buttons.Length;i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelsUnlocked; i++)
        {
            buttons[i].interactable = true;
        }


    }
    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }
}
