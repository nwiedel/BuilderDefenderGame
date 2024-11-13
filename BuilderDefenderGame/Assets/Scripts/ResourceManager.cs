using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Managerklasse zur Erzeuung von Resourcen.
/// </summary>
public class ResourceManager : MonoBehaviour
{
    /// <summary>
    /// Singelton pattern
    /// </summary>
    public static ResourceManager Instance { get; private set; }

    /// <summary>
    /// Eventdefinition wenn sich ein Resourceamount ändert.
    /// </summary>
    public event EventHandler OnResourceAmountChanged;

    /// <summary>
    /// Stellt die Menge der Resourcen nach Art dar.
    /// </summary>
    private Dictionary<ResourceTypeSO, int> resourceAmountDictionary;

    private void Awake()
    {
        Instance = this;

        resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();

        ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);

        foreach (ResourceTypeSO resourceType in resourceTypeList.list)
        {
            resourceAmountDictionary[resourceType] = 0;
        }

        TestLogResourceAmountDictionary();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);
            AddResource(resourceTypeList.list[0], 2);
            TestLogResourceAmountDictionary();
        }
    }

    private void TestLogResourceAmountDictionary()
    {
        foreach(ResourceTypeSO resourceType in resourceAmountDictionary.Keys)
        {
            Debug.Log(resourceType.nameString + ": " + resourceAmountDictionary[resourceType]); 
        }
    }

    public void AddResource(ResourceTypeSO resourceType, int amount)
    {
        resourceAmountDictionary[resourceType] += amount;

        // Event wird ausgelöst, wenn sich der Resourceamount ändert!
        // Im UI wird daraufgelauscht
        if(OnResourceAmountChanged != null)
        {
            OnResourceAmountChanged(this, EventArgs.Empty);
        }
        // Kurzform
        // OnResourceAmountChanged?.Invoke(this, EventArgs.Empty);

        TestLogResourceAmountDictionary();
    }

    public int GetResourceAmount(ResourceTypeSO resourceType)
    {
        return resourceAmountDictionary[resourceType];
    }
}
