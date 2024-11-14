using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Die Klasse steuert die Cameraführung
/// </summary>
public class CameraHandler : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 moveDir = new Vector2(x, y).normalized;
    }
}
