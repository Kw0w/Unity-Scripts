using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    public AudioMixer audioMixer;
   public void SetVolume(float volume)
    {
        Debug.Log("AHSGD");
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
        
    }

    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
