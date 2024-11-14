using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingTypeSelectUI : MonoBehaviour
{
    private void Awake()
    {
        Transform btnTemplate = transform.Find("btnTemplate");
        btnTemplate.gameObject.SetActive(false);

        BuildingTypeListSO buildingTypeList =
            Resources.Load<BuildingTypeListSO>(typeof(BuildingTypeListSO).Name);

        foreach(BuildingTypeSO buildingType in buildingTypeList.list)
        {
            Transform btnTransform = Instantiate(btnTemplate, transform);
            btnTransform.gameObject.SetActive(true);

            btnTransform.Find("image").GetComponent<Image>().sprite = buildingType.sprite
;        }
    }
}
