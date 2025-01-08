using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        this.Moving();
    }
    protected virtual void Moving()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
