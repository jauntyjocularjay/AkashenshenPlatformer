using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteAlways]
public class PlatformerManager : Manager
{
    Transform cameraTX;
    
    new void Start()
    {
        base.Start();
        cameraTX = Camera.main.GetComponent<Transform>();
    }
}


