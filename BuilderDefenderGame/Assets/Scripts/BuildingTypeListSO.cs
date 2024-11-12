using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Liste aller baubaren Geb�ude.
/// </summary>
[CreateAssetMenu (menuName = "ScriptableObjects/BuildingTypeList")]
public class BuildingTypeListSO : ScriptableObject
{
    public List<BuildingTypeSO> list;
}
