using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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


    public Vector3 Intersection(LinearFunction m)
    {
        Vector3 interectionPoint = new Vector3(0,0,0);
        float intersection_x = (m.intercept-this.intercept)/(this.slope - m.slope); 
        float interesection_y = this.slope * intersection_x + this.intercept;
        interectionPoint.x = intersection_x;
        interectionPoint.y = interesection_y;
        return interectionPoint;
    }
}
