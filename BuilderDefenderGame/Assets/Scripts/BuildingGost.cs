using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGost : MonoBehaviour
{
    private GameObject spriteGameObject;

    private void Awake()
    {
        spriteGameObject = transform.Find("sprite").gameObject;

        Hide();
    }

    private void Update()
    {
        transform.position = UtilsClass.GetMouseWorldPosition();
    }

    private void Show(Sprite gostSprite)
    {
        spriteGameObject.SetActive(true);
        spriteGameObject.GetComponent<SpriteRenderer>().sprite = gostSprite;
    }

    private void Hide()
    {
        spriteGameObject.SetActive(false);
    }
}
