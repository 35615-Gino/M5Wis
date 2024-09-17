using UnityEngine;

public class Triangle : MonoBehaviour
{
    [SerializeField] Transform A, B, C;
    [SerializeField] LineRenderer AB, BC, AC;

    LinearFunction2 ab = new LinearFunction2(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        ab.slope = 0;
        ab.intercept = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AB.SetPosition(0, A.position);
        AB.SetPosition(1, B.position);
        AB.SetPosition(0, new Vector3(0, ab.GetY(0), 0));
        AB.SetPosition(1, new Vector3(0, ab.GetY(10), 0));
    }
}
