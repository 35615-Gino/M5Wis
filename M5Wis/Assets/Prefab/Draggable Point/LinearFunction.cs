using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearFunction
{

    public float slope;
    public float intercept;
    public LinearFunction(float slope, float intercept)
    {
        Debug.Log("We Died");
        this.slope = slope;
        this.intercept = intercept;
    }

    public float GetY(float x)
    {
        return x*slope + intercept;
    }
            
    public void LinetroughTwoPoint(Vector3 A, Vector3 B)
    {
        this.slope = (B.y - A.y)/(B.x - A.x);
        this.intercept = B.y - this.slope * B.x;
    }
}
