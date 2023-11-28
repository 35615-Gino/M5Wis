using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheLine : MonoBehaviour
{
    public LinearFunction f;
    public GameObject A;
    public GameObject B;
    public GameObject line;
    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        f = new LinearFunction(2,3);
        lineRenderer = line.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        f.LinetroughTwoPoint(A.transform.position, B.transform.position);
        lineRenderer.SetPosition(0, new Vector3(-10,f.GetY(-10),0));
        lineRenderer.SetPosition(1, new Vector3(10, f.GetY(10), 0));
        //Debug.Log(f.slope);
        //Debug.Log(f.intercept);
    }
}
