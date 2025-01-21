﻿using UnityEngine;

[ExecuteAlways]
public abstract class Manager : MonoBehaviour
{
    Camera cam;
    readonly float mapUnitSide = 1.40625f;
    [Header("Camera")]
    public float size = 4.0f;
    public void Start()
    {
        cam = Camera.main;
        cam.orthographicSize = size * mapUnitSide;
    }
}
