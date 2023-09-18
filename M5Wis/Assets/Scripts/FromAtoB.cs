using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromAtoB : MonoBehaviour
{
    [SerializeField] private GameObject A;
    [SerializeField] private GameObject B;
    [SerializeField] private GameObject Enemy;
    private Vector3 velocity;
    private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Enemy.transform.position = A.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = B.transform.position - Enemy.transform.position;
        float magnitude = direction.magnitude;
        Vector3 normDir = Vector3.Normalize(direction);
        velocity = normDir * speed * Time.deltaTime;
        Enemy.transform.position += velocity;

        float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;
        Enemy.transform.localEulerAngles = new Vector3(0,0,angle);
                    
        if(velocity.magnitude > magnitude)
        {
            Enemy.transform.position = A.transform.position;
        }
    }
}
