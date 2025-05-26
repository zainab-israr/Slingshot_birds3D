using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(Slider))]

public class settings : MonoBehaviour
{
    Slider slider
    {
        get { 
            return GetComponent<Slider>(); 
    }
  }
    public AudioMixer audioMixer;

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void setMusic(float music)
    {
        audioMixer.SetFloat("music", music);
    }

}
