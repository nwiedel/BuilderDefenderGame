using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Liste der zu erzeugenden Resourcen.
/// </summary>
[CreateAssetMenu(menuName = "ScriptableObjects/ResourceTypeList")]
public class ResourceTypeListSO : ScriptableObject
{
    public List<ResourceTypeSO> list;
}
