using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float xaxis = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yaxis = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        rb.AddForce(new Vector3(xaxis, yaxis));
    }
}
