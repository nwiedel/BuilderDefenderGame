using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ScriptableObject Klasse zur Spezifizierung von Gebäuden
/// </summary>
[CreateAssetMenu(menuName = "ScriptableObjects/BuildingType")]
public class BuildingTypeSO : ScriptableObject
{
    public string nameString;

    public Transform prefab;

    public ResourceGeneratorData resourceGeneratorData;

    public Sprite sprite;
}
