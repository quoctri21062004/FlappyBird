using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    protected Vector3 direction;
    protected float gravity = -9.8f;
    private void Update()
    {
        this.GetGravity();
        Vector3 jumpForce = GameManager.instance.GameCtrl.playerInput.GetInputPlayer();

        if (jumpForce != Vector3.zero)
        {
            direction = jumpForce;
        }
        this.Moving(this.direction, this.gravity);
    }
    protected virtual void Moving(Vector3 direction, float gravity)
    {
        GameManager.instance.GameCtrl.Player.transform.position += direction * Time.deltaTime;
    }
    protected virtual void GetGravity()
    {
        this.direction.y += gravity * Time.deltaTime;
    }
}
