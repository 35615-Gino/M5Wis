using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] Renderer bgr;
    float speed = 0.5f;


    // Update is called once per frame
    void Update()
    {
        bgr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
