﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackgroundQuad : MonoBehaviour
{
    public float bgSpeed;
    public Renderer bgRend;
    
    // Update is called once per frame
    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }
}
