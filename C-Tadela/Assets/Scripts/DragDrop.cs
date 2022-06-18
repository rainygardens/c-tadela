using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Vector2 startPosition;
    private bool isDragging = false;
    private bool isOverCity = false;
    private GameObject city;

    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverCity = true;
        city = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverCity = false;
        city = collision.gameObject;
    }

    public void StartDrag()
    {
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        isDragging = false;
        if (isOverCity)
        {
            transform.SetParent(city.transform, false);
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
