using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
   protected MeshRenderer meshRenderer;
    public float animationSpeed = 1f;

    protected void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    protected void Reset()
    {
        this.ResetValue();
    }
    protected void Update()
    {
        this.UpdateSpeed();
    }

    protected virtual void UpdateSpeed()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
    protected virtual void ResetValue()
    {
        //
    }

}
