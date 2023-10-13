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
    public GameObject hAC;
    public GameObject hBC;

    private LinearFunction ChAB = new LinearFunction(1, 1);
    public GameObject chab;
    private LineRenderer lchAB;


    private LinearFunction ChBC = new LinearFunction(1, 1);
    public GameObject chbc;
    private LineRenderer lchBC;

    public GameObject centroid;


    // Start is called before the first frame update
    void Start()
    {
        lrAB = AB.GetComponent<LineRenderer>();
        lrAC = AC.GetComponent<LineRenderer>();
        lrBC = BC.GetComponent<LineRenderer>();
        lchAB = chab.GetComponent<LineRenderer>();
        lchBC = chbc.GetComponent<LineRenderer>();

       
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
        hAC.transform.position = new Vector3((A.transform.position.x + C.transform.position.x) / 2, (A.transform.position.y + C.transform.position.y) / 2, 0);
        hBC.transform.position = new Vector3((B.transform.position.x + C.transform.position.x) / 2, (B.transform.position.y + C.transform.position.y) / 2, 0);

        ChAB.LinetroughTwoPoint(C.transform.position, hAB.transform.position);
        lchAB.SetPosition(0, new Vector3(-10,ChAB.GetY(-10),0));
        lchAB.SetPosition(1, new Vector3(10, ChAB.GetY(10), 0));

        ChBC.LinetroughTwoPoint(B.transform.position, hAC.transform.position);
        lchBC.SetPosition(0, new Vector3(-10, ChBC.GetY(-10), 0));
        lchBC.SetPosition(1, new Vector3(10, ChBC.GetY(10), 0));

        centroid.transform.position = ChAB.Intersection(ChBC);

    }
}
