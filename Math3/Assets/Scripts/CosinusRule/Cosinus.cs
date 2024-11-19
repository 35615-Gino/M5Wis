using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosinus : MonoBehaviour
{
    [SerializeField] private Transform A, B, C;
    [SerializeField] private LineRenderer AB, BC, AC;

    private float a, b, c;
    private float alpha, beta, gamma;

    void Update()
    {
        a = Vector3.Magnitude(C.position - B.position);
        b = Vector3.Magnitude(C.position - A.position);
        c = Vector3.Magnitude(B.position - A.position);
        
        AB.SetPosition(0, A.position);
        AB.SetPosition(1,B.position);
        BC.SetPosition(0, B.position);
        BC.SetPosition(1,C.position);
        AC.SetPosition(0, A.position);
        AC.SetPosition(1,C.position);
        // a^2 = b^2 + c^2 - 2*b*c*cos(alpha)
        // alpha = acos (a^2 - b^2 -c^2)/(-2 * b * c)

        alpha = Mathf.Acos(((a * a) - (b * b) - (c * c)) / (-2 * b * c)) * Mathf.Rad2Deg;
        Debug.Log(alpha);


        float alphaTest = Vector3.Angle(B.position - A.position, C.position - A.position);
        print(alpha + "en" + alphaTest);
    }
}
