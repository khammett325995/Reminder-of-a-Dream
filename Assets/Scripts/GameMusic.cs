using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    public AudioClip myGameMusic;
    private AudioSource myAudioPath;

    private void Awake()
    {
        myAudioPath = GetComponent<AudioSource>();
        if (myAudioPath == null)
        {
             myAudioPath = gameObject.AddComponent<AudioSource>();
        } if (myGameMusic != null)
        {
            myAudioPath.clip = myGameMusic;
            myAudioPath.loop = true;
            myAudioPath.playOnAwake = true;
            myAudioPath.Play();
        }
     }
}