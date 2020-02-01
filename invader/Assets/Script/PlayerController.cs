﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
        WebGLInput.captureAllKeyboardInput = false;
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        // 左に移動
        if (Input.GetKey (KeyCode.LeftArrow)) {
            this.transform.Translate (-0.1f,0.0f,0.0f);
        }
        // 右に移動
        if (Input.GetKey (KeyCode.RightArrow)) {
            this.transform.Translate (0.1f,0.0f,0.0f);
        }
        // FIRE
        if (Input.GetKey (KeyCode.Space)) {
            this.transform.Translate (0.1f,0.0f,0.0f);
        }
    }
}
