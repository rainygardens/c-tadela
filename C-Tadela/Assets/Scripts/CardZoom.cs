using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZoom : MonoBehaviour
{
    public GameObject Tabletop;

    private GameObject zoomCard;

    public void Awake()
    {
        Tabletop = GameObject.Find("Main Tabletop");
    }

    public void OnHoverEnter()
    {
        zoomCard = Instantiate(gameObject, new Vector2(Input.mousePosition.x, Input.mousePosition.y + 200), Quaternion.identity);
        zoomCard.transform.SetParent(Tabletop.transform, true);
        zoomCard.layer = LayerMask.NameToLayer("Zoom");

        RectTransform rect = zoomCard.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(240, 344);
    }

    public void OnHoverExit()
    {
        Destroy(zoomCard);
    }
}
