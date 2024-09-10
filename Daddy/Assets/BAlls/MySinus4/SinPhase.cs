using UnityEngine;

public class SinPhase : MonoBehaviour
{
    [SerializeField] private GameObject Sphere;
    int NumberOfSpheres = 20;
    [SerializeField] private GameObject[] Spheres;
    float t = 0;

    // Start is called before the first frame update
    void Start()
    {
        Spheres = new GameObject[NumberOfSpheres];
        for (int i = 0; i < NumberOfSpheres; i++)
        {
            Spheres[i] = Instantiate(Sphere, new Vector3(i, 0, 0), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < NumberOfSpheres; i++)
        {
            Spheres[i].transform.position = Wave(Spheres[i].transform.position, i);
        }
        t += Time.deltaTime;
    }

    Vector3 Wave(Vector3 pos, float i)
    {
        float xpos = pos.x;
        float ypos = Mathf.Sin((4 + t) + i / 5) + Mathf.Sin((4 + t) + i / 5);
        float zpos = Mathf.Cos((4 + t) + i / 5);

        return new Vector3(xpos, ypos, zpos);
    }
}
