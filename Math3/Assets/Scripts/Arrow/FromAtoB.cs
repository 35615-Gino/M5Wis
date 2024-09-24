using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromAtoB : MonoBehaviour
{
    [SerializeField] GameObject A;
    [SerializeField] GameObject B;
    [SerializeField] Arrow arrow;

    Vector3 velocity;
    float speed = 2;
    float distance = 0;
    float tmax, t = 0;

    void Start()
    {
        arrow.transform.position = A.transform.position;
        velocity = B.transform.position - A.transform.position;
        distance = velocity.magnitude;
        velocity = velocity.normalized;
        velocity = velocity * speed;
        arrow.myVector = velocity;

        tmax = distance / speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (t <= tmax ) 
        {
            arrow.transform.position += velocity * Time.deltaTime;
            t += Time.deltaTime;
        }
        
    }
}
