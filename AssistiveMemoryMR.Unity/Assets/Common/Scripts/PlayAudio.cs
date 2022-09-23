using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject PlayIcon;
    public GameObject PauseIcon;
    public GameObject PlayText;
    public GameObject PauseText;

  
    public void Play()
    {

        if (this.audioSource.isPlaying)
        {
            this.audioSource.Pause();
            PauseIcon.SetActive(false);
            PlayIcon.SetActive(true);
            PauseText.SetActive(false);
            PlayText.SetActive(true);
        }

        else
        {
            this.PauseEverything();
            this.audioSource.Play();
            PauseIcon.SetActive(true);
            PlayIcon.SetActive(false);
            PauseText.SetActive(true);
            PlayText.SetActive(false);
        }
    }

    public void PauseEverything()
    {
        AudioSource [] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audio in allAudioSources)
        {
            audio.Pause();
        }
    }
}
