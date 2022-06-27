using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragandDrop : MonoBehaviour
{
    private bool isDragging;
   public float speed = 1.5f;
     private Vector3 target;
        void Start () {
     target = transform.position;
     }
    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition =
                Camera.main.ScreenToWorldPoint(Input.mousePosition) -
                transform.position;
            transform.Translate (mousePosition);
        }
      
       
    }
}
