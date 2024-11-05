using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    /// <summary>
    /// Verweis auf das Prefa
    /// </summary>
    private BuildingTypeSO buildingType;
    /// <summary>
    /// Verweis auf die Liste der BuildingTpes
    /// </summary>
    private BuildingTypeListSO buildingTypeList;

    /// <summary>
    /// Referenz auf die MainCamera
    /// </summary>
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;

        buildingTypeList = Resources.Load<BuildingTypeListSO>(typeof(BuildingTypeListSO).Name);
        buildingType = buildingTypeList.list[0];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(buildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            buildingType = buildingTypeList.list[0];
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            buildingType = buildingTypeList.list[1];
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
