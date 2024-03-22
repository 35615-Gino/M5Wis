using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
