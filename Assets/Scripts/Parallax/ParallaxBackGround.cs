using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackGround : Parallax
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.animationSpeed = 0.005f;
    }
}
