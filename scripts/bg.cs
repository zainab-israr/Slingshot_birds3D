using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bg : MonoBehaviour
{
    public static Sprite imageSource;
    public Sprite src;
    public void background()
    {
        imageSource = src;
        SceneManager.LoadScene("Level 1");
    }

}
