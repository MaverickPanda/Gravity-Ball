using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour
{
    public AudioSource MyAudioSource;
    public static bool audioPlaying;

    // Start is called before the first frame update
    void Start()
    {
        if (audioPlaying == false)
        {
            MyAudioSource.Play();
        }
    }
    

}
