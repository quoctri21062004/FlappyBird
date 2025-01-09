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
        this.JumpForce();
        this.Moving(this.direction);
        this.SoundMoving();
        this.UpdateRot();
    }
    protected virtual void JumpForce()
    {
        Vector3 jumpForce = GameManager.instance.GameCtrl.playerInput.GetInputPlayer();

        if (jumpForce != Vector3.zero && GameManager.instance.GameCtrl.Player.transform.position.y < 3.5)
        {
            direction = jumpForce;
        }
    }

    protected virtual void Moving(Vector3 direction)
    {
        GameManager.instance.GameCtrl.Player.transform.position += direction * Time.deltaTime;
    }

    protected virtual void GetGravity()
    {
        this.direction.y += gravity * Time.deltaTime;
    }

    protected virtual void UpdateRot()
    {
        Quaternion rot = transform.rotation;
        if (direction.y > 0)
        {
            rot.z = direction.y * 0.02f;
            GameManager.instance.GameCtrl.Player.transform.rotation = rot;
        }
        else
        {
            rot.z = direction.y * 0.02f;
            GameManager.instance.GameCtrl.Player.transform.rotation = rot;
        }
    }

    protected virtual void SoundMoving()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.instance.GameCtrl.audioManager.GetSoundFly();
        }
    }
}
