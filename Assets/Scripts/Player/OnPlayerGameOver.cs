using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerGameOver : MonoBehaviour
{
    protected void OnTriggerEnter2D(Collider2D other)
    {
        if (transform.position != null && other.gameObject.tag == "Over")
        {
            GameManager.instance.GameCtrl.gameStatusManager.GameOver();
        }
        if (transform.position != null && other.gameObject.tag == "Ground")
        {
            GameManager.instance.GameCtrl.gameStatusManager.GameOver();
        }
    }
}
