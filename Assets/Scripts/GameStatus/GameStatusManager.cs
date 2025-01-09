using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameStatusManager : MonoBehaviour
{
    public Transform Player;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject getReady;
    public GameObject pipePrefab;
    private void Awake()
    {
        gameOver.SetActive(false);
        getReady.SetActive(true);
        Pause();
    }
    #region Play
    public void Play()
    {
        int Score = GameManager.instance.GameCtrl.scoreManager.score = 0;
        GameManager.instance.GameCtrl.scoreManager.scoreText.text = Score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        getReady.SetActive(false);

        Time.timeScale = 1f;
        this.EnableComponents(true);
        this.ClearPrefabs();
        GameManager.instance.GameCtrl.playerPos.ResetPos();
    }
    #endregion
    public void Pause()
    {
        Time.timeScale = 0f;
        EnableComponents(false);
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        GameManager.instance.GameCtrl.audioManager.GetSoundGameOver();

        Pause();
    }

    protected virtual void EnableComponents(bool enable)
    {
        if (Player.GetComponent<Collider>() != null)
        { Player.GetComponent<Collider>().enabled = enable; }
        if (Player.GetComponent<Rigidbody>() != null)
        { Player.GetComponent<Rigidbody>().isKinematic = !enable; }
    }

    protected virtual void ClearPrefabs()
    {
        GameObject[] activePipes = GameObject.FindGameObjectsWithTag("Pipe");
        foreach (var pipe in activePipes)
        {
            Destroy(pipe);
        }
    }
}
