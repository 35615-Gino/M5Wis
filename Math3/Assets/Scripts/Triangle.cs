using UnityEngine;

public class Triangle : MonoBehaviour
{
    [SerializeField] Transform A, B, C;
    [SerializeField] LineRenderer AB, BC, AC;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AB.SetPosition(0, A.position);
        AB.SetPosition(1, B.position);
        BC.SetPosition(0, B.position);
        BC.SetPosition(1, C.position);
        AC.SetPosition(0, A.position);
        AC.SetPosition(1, C.position);
    }
}
