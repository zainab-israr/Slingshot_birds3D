using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class image : MonoBehaviour
{
    public Image i;

    private void Awake()
    {
        i.sprite = bg.imageSource;
    }
}
