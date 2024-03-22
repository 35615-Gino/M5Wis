using UnityEngine;

public class Lcokstate : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            canvas.SetActive(true);
        }
    }
}
