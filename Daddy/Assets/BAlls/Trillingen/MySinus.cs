using UnityEngine;

public class MySinus : MonoBehaviour
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
        return new Vector3(Theta, Mathf.Sin(Theta), 0);
    }
}
