using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioBackground;
    public AudioClip audioClip;
    public AudioClip background;
    public AudioClip audioFly;
    public AudioClip audioDie;
    public AudioClip audioGameOver;
    public AudioClip audioScore;

    
    public void GetSound()
    {
        audioSource.PlayOneShot(audioClip);
    } 
    public void GetSoundFly()
    {
        audioSource.PlayOneShot(audioFly);
    }
    public void GetSoundDie()
    {
        audioSource.PlayOneShot(audioDie);
    }
    public void GetSoundScore()
    {
        audioSource.PlayOneShot(audioScore);
    }
    //public void GetSoundBackground()
    //{
    //    audioBackground.Play(background);
    //}
}
