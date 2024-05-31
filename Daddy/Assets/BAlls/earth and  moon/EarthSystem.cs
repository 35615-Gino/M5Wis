using UnityEngine;

public class EarthSystem : MonoBehaviour
{
    [SerializeField] private GameObject Earth;
    [SerializeField] private GameObject Moon;

    Vector3 MoonAcceleration;
    Vector3 MoonDirection;
    float MoonSpeed;


    Vector3 MoonVelocity;


    // Start is called before the first frame update
    void Start()
    {
        MoonVelocity = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 differenceVector = Earth.transform.position - Moon.transform.position;
        float distance = differenceVector.magnitude;

        MoonDirection = differenceVector.normalized;
        MoonSpeed = 5 / (distance * distance);
        MoonAcceleration = MoonSpeed * MoonDirection;
        MoonVelocity += MoonAcceleration * Time.deltaTime;
        Moon.transform.position += MoonVelocity * Time.deltaTime;
        Earth.transform.Rotate(0, -0.2f, 0);
    }
}
