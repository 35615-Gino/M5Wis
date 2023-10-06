using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentroidManager : MonoBehaviour
{
    public DragablePoint A;
    public DragablePoint B;
    public DragablePoint C;

    public GameObject AB;
    public GameObject AC;
    
    private LineRenderer lrAB;
    private LineRenderer lrAC;


    private LinearFunction fab = new LinearFunction(1,1);
    private LinearFunction fac = new LinearFunction(1,1);
    // Start is called before the first frame update
    void Start()
    {
        lrAB = AB.GetComponent<LineRenderer>();
        lrAC = AC.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

        fab.LinetroughTwoPoint(A.transform.position, B.transform.position);
        lrAB.SetPosition(0, new Vector3(-10,fab.GetY(-10),0));
        lrAB.SetPosition(1, new Vector3(10,fab.GetY(10),0));

        fac.LinetroughTwoPoint(A.transform.position, C.transform.position);
        lrAC.SetPosition(0, new Vector3(-10, fac.GetY(-10), 0));
        lrAC.SetPosition(1, new Vector3(10, fac.GetY(10), 0));
    }
}
