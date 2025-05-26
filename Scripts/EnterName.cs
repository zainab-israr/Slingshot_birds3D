using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterName : MonoBehaviour
{
    public InputField enterName;
    public static string name;
   

    
    public void okee()
    {
        name = enterName.text.ToString();
        HighScoreManager obj;

            GameObject gameObject = new GameObject("HighscoreManager");
            obj = gameObject.AddComponent<HighScoreManager>();
       
        obj.enterData();
        //SceneManager.LoadScene("Highscore");
        enterName.text = string.Empty;
    }
}
