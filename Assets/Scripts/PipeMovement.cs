using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 5f;
    protected float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f ;
    }
    private void Update()
    {
        this.Moving();
        this.Despawn();
    }
    protected virtual void Moving()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    protected virtual void Despawn()
    {
        if (transform.position.x < leftEdge) { 
            Destroy(gameObject);
        }
    }
}
