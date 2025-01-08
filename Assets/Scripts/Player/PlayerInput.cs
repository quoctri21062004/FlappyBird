using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    protected float strength = 5f;
  
    public virtual Vector3 GetInputPlayer()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
        
            return Vector3.up*strength;
        }
        return Vector3.zero;
    }
  
}
