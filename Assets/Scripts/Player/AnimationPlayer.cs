using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    protected int spriteIndex;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }
    protected virtual void AnimateSprite()
    {
        spriteIndex++;
        if (spriteIndex == sprites.Length)
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }
}
