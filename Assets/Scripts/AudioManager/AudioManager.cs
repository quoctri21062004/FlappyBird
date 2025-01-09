using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioFly;
    public AudioClip audioGameOver;
    public AudioClip audioScore;

    public void GetSoundFly()
    {
        audioSource.PlayOneShot(audioFly);
    }
    public void GetSoundScore()
    {
        audioSource.PlayOneShot(audioScore);
    }
    public void GetSoundGameOver()
    {
        audioSource.PlayOneShot(audioGameOver);
    }
}
