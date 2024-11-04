using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    /// <summary>
    /// Referenz auf die MainCamera
    /// </summary>
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        
        
    }

    /// <summary>
    /// Ermittelt die Position der Mous in World-Koordinaten
    /// </summary>
    /// <returns>mouseWorldPosition</returns>
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        return mouseWorldPosition;
    }
}
