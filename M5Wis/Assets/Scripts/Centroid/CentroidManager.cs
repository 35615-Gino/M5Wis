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
    public GameObject BC;
    
    private LineRenderer lrAB;
    private LineRenderer lrAC;
    private LineRenderer lrBC;


    private LinearFunction fab = new LinearFunction(1,1);
    private LinearFunction fac = new LinearFunction(1,1);
    private LinearFunction fbc= new LinearFunction(1,1);

    public GameObject hAB;
    // Start is called before the first frame update
    void Start()
    {
        lrAB = AB.GetComponent<LineRenderer>();
        lrAC = AC.GetComponent<LineRenderer>();
        lrBC = BC.GetComponent<LineRenderer>();
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

        fbc.LinetroughTwoPoint(B.transform.position, C.transform.position);
        lrBC.SetPosition(0, new Vector3(-10, fbc.GetY(-10), 0));
        lrBC.SetPosition(1, new Vector3(10, fbc.GetY(10), 0));

        hAB.transform.position = new Vector3((A.transform.position.x + B.transform.position.x) /2 , (A.transform.position.y + B.transform.position.y) /2,0);

    }
}
