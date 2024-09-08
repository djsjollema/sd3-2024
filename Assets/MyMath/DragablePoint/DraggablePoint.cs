using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggablePoint : MonoBehaviour
{
    public Color newColor = Color.white;
    public SpriteRenderer spriteRenderer;
    bool isDraggable = false;
    void Start()
    {

    }

    void Update()
    {
        spriteRenderer.color = newColor;

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if(isDraggable)
        {
            transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
        }
        
    }

    private void OnMouseDown()
    {
        isDraggable = true;
    }

    private void OnMouseUp()
    {
        isDraggable = false;
    }
}
