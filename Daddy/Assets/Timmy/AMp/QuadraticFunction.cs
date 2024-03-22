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

}
