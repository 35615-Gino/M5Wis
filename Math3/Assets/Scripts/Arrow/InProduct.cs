using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InProduct : MonoBehaviour
{
    [SerializeField] private Transform A,B,C;
    [SerializeField] private Arrow arrow;
    [SerializeField] private Arrow w;
    [SerializeField] private Arrow p;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        arrow.transform.position = A.transform.position;
        arrow.myVector = new Vector3(B.position.x - A.position.x,  B.position.y -A.position.y, 0);

        w.transform.position = A.transform.position;
        w.myVector = new Vector3(C.position.x - A.position.x,  C.position.y -A.position.y, 0);
        w.myVector.Normalize();

        w.myVector = w.myVector *  Vector3.Dot(arrow.myVector, w.myVector);

        p.transform.position = A.transform.position;
        p.myVector = arrow.myVector - w.myVector;
    }
}
