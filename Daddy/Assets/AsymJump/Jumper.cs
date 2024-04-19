using UnityEngine;

public class Jumper : MonoBehaviour
{
    Vector3 velocity;
    Vector3 acceleration;
    float gravity = -10;
    float beginSpeed = 10;
    float beginHeight = -3;

    [SerializeField] float t = 0;

    enum State { grounded, aireborne };
    State state = State.grounded;

    QuadraticFunction jump;

    void Start()
    {
        jump = new QuadraticFunction(gravity / 2, beginSpeed, beginHeight);
    }

    void Update()
    {
        Debug.Log(jump.getRoots());

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;


        if (state == State.grounded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                state = State.aireborne;
                velocity = new Vector3(0, beginSpeed, 0);
                acceleration = new Vector3(3 / jump.getRoots().y, gravity, 0);
            }

        }

        if (state == State.aireborne)
        {
            t += Time.deltaTime;
            if (t > jump.getRoots().y)
            {
                state = State.grounded;
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
            }

        }
    }
}