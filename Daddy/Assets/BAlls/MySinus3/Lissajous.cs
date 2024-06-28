using UnityEngine;

public class Lissajous : MonoBehaviour
{
    [SerializeField] private GameObject A;

    float t = 0;

    void Update()
    {
        float t1 = t + Time.deltaTime;
        t += Time.deltaTime;
        A.transform.position = myLissajous(t, 3, 3, 3, 5, 3, 3);
        A.transform.LookAt(myLissajous(t1, 3, 3, 3, 5, 3, 3));
    }

    Vector3 myLissajous(float t, float Ax, float Ay, float Az, float af_x, float af_y, float af_z)
    {

        float Xpos = Ax * Mathf.Sin(af_x * t) + Ax * Mathf.Sin(af_x * t);
        float Ypos = Ay * Mathf.Cos(af_y * t);
        float Zpos = Az * Mathf.Sin(af_z * t);

        return new Vector3(Xpos, Ypos, Zpos);
    }
}
