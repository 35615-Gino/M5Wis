using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePointManager : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform C;

    public Transform hAB;
    public Transform hAC;
    public Transform hBC;

    public Transform MiddlePoint;

    public LinearFunction fAB = new LinearFunction(1,1);
    public LinearFunction fBC = new LinearFunction(1,1);
    public LinearFunction fAC = new LinearFunction(1, 1);

    public LineRenderer lrAB;
    public LineRenderer lrBC;
    public LineRenderer lrAC;

    public LinearFunction fpAB = new LinearFunction(1, 1);
    public LinearFunction fpBC = new LinearFunction(1, 1);
    public LinearFunction fpAC = new LinearFunction(1, 1);

    public LineRenderer lrAB_p;
    public LineRenderer lrBC_p;
    public LineRenderer lrAC_p;

    void Update()
    {
        fAB.LinetroughTwoPoint(A.position, B.position);
        fBC.LinetroughTwoPoint(B.position, C.position);
        fAC.LinetroughTwoPoint(A.position, C.position);

        drawLine(lrAB,fAB);
        drawLine(lrBC, fBC);
        drawLine(lrAC, fAC);

        hAB.position = (A.position + B.position)/2;
        hBC.position = (B.position + C.position)/2;
        hAC.position = (A.position + C.position)/ 2;

        fpAB.slope = -1 / fAB.slope;
        fpBC.slope = -1 / fBC.slope;
        fpAC.slope = -1 / fAC.slope;
        fpAB.intercept = hAB.position.y - hAB.position.x * fpAB.slope;
        fpBC.intercept = hBC.position.y - hBC.position.x * fpBC.slope;
        fpAC.intercept = hAC.position.y - hAC.position.x * fpAC.slope;

        drawLine(lrAB_p, fpAB);
        drawLine(lrBC_p, fpBC);
        drawLine(lrAC_p, fpAC);

        MiddlePoint.position = fpAB.Intersection(fpAC);
        float dist = Vector3.Distance(MiddlePoint.position, A.position) * 2;
        MiddlePoint.localScale = new Vector3(dist, dist, 1);
    }

    public void drawLine(LineRenderer lr, LinearFunction f)
    {
        lr.SetPosition(0, new Vector3(-20, f.GetY(-20),0));
        lr.SetPosition(1, new Vector3(20, f.GetY(20), 0));
    }
}
