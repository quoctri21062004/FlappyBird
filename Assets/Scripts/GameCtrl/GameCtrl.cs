using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameCtrl : MonoBehaviour
{
    public Transform Player;
    public ScoreManager scoreManager;
    public GameStatusManager gameStatusManager;
    public PlayerInput playerInput;
    public PlayerMoving playerMoving;
    public PlayerPos playerPos;
    public AudioManager audioManager;
    private void Awake()
    {
        Player = GameObject.FindWithTag("Player").transform;
        playerInput = Player.GetComponentInChildren<PlayerInput>();
        playerMoving = Player.GetComponentInChildren<PlayerMoving>();
        playerPos = Player.GetComponentInChildren<PlayerPos>();
     
        if (playerInput == null)
        {
            Debug.LogError("PlayerInput not found on Player.");
        }
        if (playerMoving == null)
        {
            Debug.LogError("PlayerMoving not found on Player.");
        }


        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        if (scoreManager==null)
        {
            Debug.LogError("ScoreManager not found.");
        }

        gameStatusManager = GameObject.Find("GameStatusManager").GetComponent<GameStatusManager>();

        if(gameStatusManager == null)
        {
            Debug.LogError("GameStatusManager not found.");
        }
    }
}
