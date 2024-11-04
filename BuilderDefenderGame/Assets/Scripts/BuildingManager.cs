using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    /// <summary>
    /// Verweis auf das Prefa
    /// </summary>
    [SerializeField] private Transform pfWoodHarvester;

    /// <summary>
    /// Referenz auf die MainCamera
    /// </summary>
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pfWoodHarvester, GetMouseWorldPosition(), Quaternion.identity);
        }
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
