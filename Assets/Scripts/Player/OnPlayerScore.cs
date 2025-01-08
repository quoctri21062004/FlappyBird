using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerScore : MonoBehaviour
{
    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (transform.position != null && other.gameObject.tag == "Score")
        {
            GameManager.instance.GameCtrl.audioManager.GetSoundScore();
            GameManager.instance.GameCtrl.scoreManager.IncreaseScore();
        }
    }
}
