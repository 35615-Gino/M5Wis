using UnityEngine;

public class DragablePoint : MonoBehaviour
{
    private Vector3 mousePosition;
    public bool isDrag = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        if (isDrag)
        {
            this.transform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("eet kaas");
        isDrag = true;
    }

    private void OnMouseUp()
    {
        isDrag = false;
        Debug.Log("soup");
    }
}
