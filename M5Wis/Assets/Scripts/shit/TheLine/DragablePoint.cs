using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragablePoint : MonoBehaviour
{
    private Vector2 mousePosition;
    public bool dragging = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        if(dragging)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            this.transform.position = mousePosition;
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("eet kaas");
        dragging= true;
    }

    private void OnMouseUp()
    {
        dragging= false;
        Debug.Log("soup");
    }
}
