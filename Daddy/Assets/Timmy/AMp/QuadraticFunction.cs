using UnityEngine;


public class QuadraticFunction
{
    float a, b, c;
    public QuadraticFunction(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public float getY(float x)
    {
        return a * x * x + b * x + c;
    }

    public Vector2 getRoots()
    {
        float Discriminant = (this.b * this.b) - (4 * this.a * this.c);
        Debug.Log(Discriminant);
        float ans1 = (-this.b + Mathf.Sqrt(Discriminant)) / (2 * this.a);
        float ans2 = (-this.b - Mathf.Sqrt(Discriminant)) / (2 * this.a);


        return new Vector2(ans1, ans2);
    }
}