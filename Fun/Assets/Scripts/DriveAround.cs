using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveAround : MonoBehaviour
{
    [SerializeField] private float speed = 50;
    [SerializeField] private float decellerate = 0.04f;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        if (inputH != 0) {
            transform.Rotate(0, inputH, 0);
            
        }
       
           
        float inputV = Input.GetAxis("Vertical");
        if (inputV != 0)
        {

            float move = speed * Time.deltaTime * inputV;
            rb.velocity += (transform.forward * move);
        }
        float dot = Vector3.Dot(transform.forward, rb.velocity);
        rb.velocity -= transform.forward * decellerate * dot;
    
            /*
            if (dot > 0.1f)
            {
                rb.velocity -= transform.forward * decellerate;
            }
            else if (dot < 0.1f) {
                rb.velocity += transform.forward * decellerate;
            }
            */
    }
}
