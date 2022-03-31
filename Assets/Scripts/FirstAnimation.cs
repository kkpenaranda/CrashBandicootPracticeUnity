using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void AddScript()
    {
        gameObject.AddComponent(typeof(Movement));
        GameObject.Find("Main Camera").AddComponent(typeof(CameraController));
    }

    
}
