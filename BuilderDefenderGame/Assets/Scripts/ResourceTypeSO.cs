using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ScriptablObject Klasse zur Erzeugung von Resourcen.
/// </summary>
[CreateAssetMenu(menuName = "ScriptableObjects/ResourceType")]
public class ResourceTypeSO : ScriptableObject
{
    public string nameString;
    public Sprite sprite;
}
