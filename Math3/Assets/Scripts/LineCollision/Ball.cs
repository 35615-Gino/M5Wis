using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 velocity = new Vector3(1, 2, 0);
    [SerializeField] private Arrow arrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        arrow.transform.position = transform.position;
        arrow.myVector = velocity;
        transform.position += velocity * Time.deltaTime;
        
    }
}
