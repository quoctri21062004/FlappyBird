using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeDespawn : MonoBehaviour
{
    protected float leftEdge;
    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    private void Update()
    {
        this.Despawn();
    }
    protected virtual void Despawn()
    {
        if (transform.position.x < leftEdge)
        {
            SimplePool2.Despawn(gameObject);
        }
    }
}
