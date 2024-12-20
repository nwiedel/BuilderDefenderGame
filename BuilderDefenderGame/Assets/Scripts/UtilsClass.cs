using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilsClass 
{
    private static Camera mainCamera;

    /// <summary>
    /// Ermittelt die Position der Mous in World-Koordinaten
    /// </summary>
    /// <returns>mouseWorldPosition</returns>
    public static Vector3 GetMouseWorldPosition()
    {
        if(mainCamera == null)
        {
            mainCamera = Camera.main;
        }

        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        return mouseWorldPosition;
    }
}
