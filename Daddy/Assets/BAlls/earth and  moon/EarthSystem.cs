using UnityEngine;

public class EarthSystem : MonoBehaviour
{
    [SerializeField] private GameObject Earth;
    [SerializeField] private GameObject Moon;
    [SerializeField] private GameObject Rocket;

    Vector3 MoonAcceleration;
    Vector3 MoonDirection;
    float MoonSpeed;

    Vector3 RocketAccelaration = Vector3.zero;
    Vector3 RocketVelocity = Vector3.zero;

    Vector3 directionEarth;
    float ForceEarth;
    Vector3 directionMoon;
    float ForceMoon;


    Vector3 MoonVelocity;


    // Start is called before the first frame update
    void Start()
    {
        RocketVelocity = new Vector3(0, 0, 0.05f);
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

        Vector3 EarthLocation = (Earth.transform.position - Rocket.transform.position);
        float distanceEarth = EarthLocation.magnitude;
        Vector3 MoonLocation = (Moon.transform.position - Rocket.transform.position);
        float distanceMoon = MoonLocation.magnitude;

        EarthLocation = EarthLocation.normalized;
        MoonLocation = MoonLocation.normalized;

        float magnitudeEarth = 0.5f / (distanceEarth * distanceEarth);
        float magnitudeMoon = 1f / (distanceMoon * distanceMoon);

        RocketAccelaration = (EarthLocation * magnitudeEarth) + (MoonLocation * magnitudeMoon) * Time.deltaTime;
        RocketVelocity += RocketAccelaration * Time.deltaTime;
        Rocket.transform.position += RocketVelocity;

    }
}
