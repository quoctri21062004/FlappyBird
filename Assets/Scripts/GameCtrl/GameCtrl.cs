using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour
{
    public Transform Player;
    public PlayerInput playerInput;
    public PlayerMoving playerMoving;
    private void Awake()
    {
        Player = GameObject.FindWithTag("Player").transform;
        playerInput = Player.GetComponentInChildren<PlayerInput>();
        playerMoving = Player.GetComponentInChildren<PlayerMoving>();
        if (playerInput == null)
        {
            Debug.LogError("PlayerInput not found on Player.");
        }
        if (playerMoving == null)
        {
            Debug.LogError("PlayerMoving not found on Player.");
        }
    }
}
