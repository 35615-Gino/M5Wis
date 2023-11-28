using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthoManager : MonoBehaviour
{
    public DragablePoint A;
    public DragablePoint B;
    public DragablePoint C;

    private LinearFunction funclineAB = new LinearFunction(1, 1);
    private LinearFunction funclineAC = new LinearFunction(1, 1);
    private LinearFunction funclineBC = new LinearFunction(1, 1);
    private LinearFunction funcPurpLineAB = new LinearFunction(1, 1);
    private LinearFunction funcPurpLineAC = new LinearFunction(1, 1);
    private LinearFunction funcPurpLineBC = new LinearFunction(1, 1);

    public LineRenderer lineAB;
    public LineRenderer lineAC;
    public LineRenderer lineBC;
    public LineRenderer purpLineAB;
    public LineRenderer purpLineAC;
    public LineRenderer purpLineBC;

    public GameObject Orthocenter;


    // Update is called once per frame
    void Update()
    {
        funclineAB.LinetroughTwoPoint(A.transform.position, B.transform.position);
        lineAB.SetPosition(0, new Vector3(-20, funclineAB.GetY(-20), 0));
        lineAB.SetPosition(1, new Vector3(20, funclineAB.GetY(20), 0));

        funclineAC.LinetroughTwoPoint(A.transform.position, C.transform.position);
        lineAC.SetPosition(0, new Vector3(-20, funclineAC.GetY(-20), 0));
        lineAC.SetPosition(1, new Vector3(20, funclineAC.GetY(20), 0));

        funclineBC.LinetroughTwoPoint(B.transform.position, C.transform.position);
        lineBC.SetPosition(0, new Vector3(-20, funclineBC.GetY(-20), 0));
        lineBC.SetPosition(1, new Vector3(20, funclineBC.GetY(20), 0));

        funcPurpLineAB.slope = -1 / funclineAB.slope;
        funcPurpLineAB.intercept = C.transform.position.y - C.transform.position.x * funcPurpLineAB.slope;
        purpLineAB.SetPosition(0, new Vector3(-20, funcPurpLineAB.GetY(-20), 0));
        purpLineAB.SetPosition(1, new Vector3(20, funcPurpLineAB.GetY(20), 0));

        funcPurpLineAC.slope = -1 / funclineAC.slope;
        funcPurpLineAC.intercept = B.transform.position.y - B.transform.position.x * funcPurpLineAC.slope;
        purpLineAC.SetPosition(0, new Vector3(-20, funcPurpLineAC.GetY(-20), 0));
        purpLineAC.SetPosition(1, new Vector3(20, funcPurpLineAC.GetY(20), 0));

        funcPurpLineBC.slope = -1 / funclineBC.slope;
        funcPurpLineBC.intercept = A.transform.position.y - A.transform.position.x * funcPurpLineBC.slope;
        purpLineBC.SetPosition(0, new Vector3(-20, funcPurpLineBC.GetY(-20), 0));
        purpLineBC.SetPosition(1, new Vector3(20, funcPurpLineBC.GetY(20), 0));

        Orthocenter.transform.position = funcPurpLineAB.Intersection(funcPurpLineAC);
    }
}
