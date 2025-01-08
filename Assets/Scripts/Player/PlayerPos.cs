using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    
   public void ResetPos()
    {
        Vector3 pos = GameManager.instance.GameCtrl.Player.transform.position;
        pos.y = 0f;
        GameManager.instance.GameCtrl.Player.transform.position=pos; 
    }
}
