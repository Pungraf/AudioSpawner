﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBehavior : MonoBehaviour
{
    public float FallingSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(0f, -FallingSpeed, 0f);
    }
}
