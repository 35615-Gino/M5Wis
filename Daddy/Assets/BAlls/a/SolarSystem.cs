using UnityEngine;

public class SolarSystem : MonoBehaviour
{

    float Radius = 2f;
    float Theta = 0f;
    float dTheta = 0.001f;

    float moonRadius = 1f;
    float moonTheta = 0f;
    float moondTheta = 0.01f;
    [SerializeField] private GameObject Earth;
    [SerializeField] private GameObject Moon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Radius * Mathf.Cos(Theta);
        float y = Radius * Mathf.Sin(Theta);

        Earth.transform.position = new Vector3(x, y, 0);

        Theta += dTheta;


        float moonX = moonRadius * Mathf.Cos(moonTheta);
        float moonY = moonRadius * Mathf.Sin(moonTheta);

        Moon.transform.position = Earth.transform.position + new Vector3(moonX, moonY, 0);

        moonTheta += moondTheta;

    }
}
