using UnityEngine;

public class Timmy : MonoBehaviour
{
    [SerializeField] Animator ani;
    [SerializeField] float gravity = -5f;
    [SerializeField] float beginSpeed = 5f;
    [SerializeField] float tmax;
    [SerializeField] float ymax;


    enum State { grounded, airborn }
    State state = State.grounded;

    Vector3 acceleration = Vector3.zero;
    Vector3 velocity = Vector3.zero;

    QuadraticFunction jumpHeight;

    float ymin;

    void Start()
    {
        ymin = transform.position.y;
        jumpHeight = new QuadraticFunction(-gravity / 2, beginSpeed, 0);
    }

    void Update()
    {
        tmax = -2 * beginSpeed / gravity;
        ymax = jumpHeight.getY(tmax / 2);


        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
        if (state == State.grounded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ani.SetTrigger("Play");
                ani.speed = 0.867f / tmax;
                //ani.Play("Jump");
                state = State.airborn;
                acceleration = new Vector3(0, gravity, 0);
                velocity = new Vector3(0, beginSpeed, 0);
            }
        }

        if (state == State.airborn)
        {
            if (transform.position.y < ymin)
            {
                state = State.grounded;
                transform.position = new Vector3(transform.position.x, ymin, transform.position.z);
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
                ani.speed = 1f;
            }
        }
    }
}
