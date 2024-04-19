using UnityEngine;

public class FinalJump : MonoBehaviour
{
    private Animator ani;

    float gravity = -5;
    float beginspeed = 7;

    Vector3 velocity;
    Vector3 acceleration;

    enum State { grounded, airborne }
    State state;

    QuadraticFunction jump;
    float duration;
    float t = 0;

    private void Start()
    {
        ani = GetComponent<Animator>();
        jump = new QuadraticFunction(gravity / 2, beginspeed, -3);
        duration = jump.getRoots().y;
        Debug.Log(duration);
    }
    void Update()
    {
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        if (state == State.grounded)
        {
            velocity = Vector3.zero;
            acceleration = Vector3.zero;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                state = State.airborne;
                ani.Play("Jump");
                acceleration = new Vector3(0, gravity, 0);
                velocity = new Vector3(3, beginspeed, 0);
            }
        }

        if (state == State.airborne)
        {
            ani.Play("Landing");
            t += Time.deltaTime;
            if (t > duration)
            {
                state = State.grounded;
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
            }
        }
    }
}
