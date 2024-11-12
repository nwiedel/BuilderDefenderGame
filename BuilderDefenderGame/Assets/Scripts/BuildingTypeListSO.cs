using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Liste aller baubaren Gebäude.
/// </summary>
[CreateAssetMenu (menuName = "ScriptableObjects/BuildingTypeList")]
public class BuildingTypeListSO : ScriptableObject
{
    public List<BuildingTypeSO> list;
}
