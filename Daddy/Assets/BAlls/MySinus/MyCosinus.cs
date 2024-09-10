using UnityEngine;

public class MyCosinus : MonoBehaviour
{
    float Theta = -Mathf.PI;
    float dTheta = 0.02f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Place();
        Theta += dTheta;
        if (Theta > Mathf.PI)
        {
            Theta = -Mathf.PI;
        }
    }

    public Vector3 Place()
    {
        return new Vector3(Mathf.Cos(Theta), Theta, 0);
    }
}
