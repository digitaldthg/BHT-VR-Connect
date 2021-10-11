﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    private Vector3 StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetToStartPosition()
    {
        transform.position = StartPosition;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}