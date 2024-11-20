using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// Generelle Klass, die das Bauen von gebäuden steuert.
/// </summary>
public class BuildingManager : MonoBehaviour
{
    public static BuildingManager Instance { get; private set; }

    /// <summary>
    /// Verweis auf das Prefa
    /// </summary>
    private BuildingTypeSO activeBuildingType;
    /// <summary>
    /// Verweis auf die Liste der BuildingTpes
    /// </summary>
    private BuildingTypeListSO buildingTypeList;

    /// <summary>
    /// Referenz auf die MainCamera
    /// </summary>
    private Camera mainCamera;

    private void Awake()
    {
        Instance = this;

        buildingTypeList = Resources.Load<BuildingTypeListSO>(typeof(BuildingTypeListSO).Name);
    }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            if (activeBuildingType != null)
            {
                Instantiate(activeBuildingType.prefab, UtilsClass.GetMouseWorldPosition(), Quaternion.identity);
            }
        }
    }

    public void SetActiveBuildingType(BuildingTypeSO buildingType)
    {
        activeBuildingType = buildingType;
    }

    public BuildingTypeSO GetActiveBuildingType() 
    {
        return activeBuildingType;
    }

}
