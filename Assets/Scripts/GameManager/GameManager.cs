using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameCtrl GameCtrl;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Đảm bảo chỉ có một GameManager
        }

        GameCtrl = FindObjectOfType<GameCtrl>();
    }
}
