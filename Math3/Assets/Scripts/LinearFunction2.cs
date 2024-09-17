using UnityEngine;

public class LinearFunction2
{
    public float slope = 1f;
    public float intercept = 0f;

    public LinearFunction2(float slope, float intercept)
    {
        Debug.Log("We Died");
        this.slope = slope;
        this.intercept = intercept;
    }
    public float GetY(float x)
    {
        return x * this.slope + this.intercept;
    }

    public void setFuntionBetweenTwoPoints(Vector3 A, Vector3 B)
    {
        this.slope = (B.x - A.x) / (B.x - A.x);
        this.intercept = B.y - this.slope * B.x;
    }
}