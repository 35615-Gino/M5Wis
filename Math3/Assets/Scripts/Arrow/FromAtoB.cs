using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromAtoB : MonoBehaviour
{
    [SerializeField] private GameObject A;
    [SerializeField] private GameObject B;
    [SerializeField] private Arrow arrow;
    private Vector3 velocity = new Vector3(0,0,0);
    private float speed = 2;
    private float distance;
    private float tMax, t=0;

    
    // Start is called before the first frame update
    void Start()
    {
        arrow.transform.position = A.transform.position;
        velocity = B.transform.position - A.transform.position;
        distance = velocity.magnitude;
        velocity = velocity.normalized;
        velocity = velocity * speed;
        arrow.myVector = velocity;
        tMax = distance / speed;
    }

    private void Update()
    {
        if (t <= tMax)
        {
            arrow.transform.position += velocity * Time.deltaTime;
            t += Time.deltaTime;
        }
    }
}
