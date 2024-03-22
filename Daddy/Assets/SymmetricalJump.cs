using UnityEngine;

public class SymmetricalJump : MonoBehaviour
{
    [SerializeField] float g = -9.8f;
    [SerializeField] float beginSpeed;
    [SerializeField] float t = 0f;

    Vector3 velocity;
    Vector3 accelaration;


    enum State
    {
        grounded,
        airborne
    }

    State MyState = State.grounded;

    // Update is called once per frame
    void Update()
    {
        velocity += accelaration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        if (MyState == State.grounded)
        {
            velocity = Vector3.zero;
            accelaration = Vector3.zero;
            transform.position = new Vector3(transform.position.x, 0, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                MyState = State.airborne;
                accelaration = new Vector3(0, g, 0);
                velocity = new Vector3(0, beginSpeed, 0);
            }
        }

        if (MyState == State.airborne)
        {
            t += Time.deltaTime;
            if (transform.position.y < 0)
            {
                MyState = State.grounded;

            }
        }
    }
}
