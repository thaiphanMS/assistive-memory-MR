using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WorldSpaceVideo : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public GameObject Play;
    public GameObject Pause;
    public GameObject PlayText;
    public GameObject PauseText;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }


    public void PlayPause()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            Pause.SetActive(false);
            Play.SetActive(true);
            PauseText.SetActive(false);
            PlayText.SetActive(true);

        }
        else
        {
            videoPlayer.Play();
            Pause.SetActive(true);
            Play.SetActive(false);
            PauseText.SetActive(true);
            PlayText.SetActive(false);
        }
    }
}
