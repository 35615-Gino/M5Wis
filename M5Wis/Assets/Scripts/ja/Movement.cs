using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 velocity = new Vector3(1, 2, 0);
    public Vector3 acceleration = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity += acceleration * Time.deltaTime;

        this.transform.position += velocity * Time.deltaTime;


        if(this.transform.position.y > 4.5)
        {
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }
        if (this.transform.position.x > 7.5)
        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }
        if (this.transform.position.y < -4.5)
        {
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }
        if (this.transform.position.x < -7.5)
        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }
    }
}