using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Mesh mesh;
    public Vector3 myVector = new Vector3(3, 4, 0);
    float angle = 0;


    void Start()
    {
        mesh = new Mesh();
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter != null)
        {
            meshFilter.mesh = mesh;
        }
        else
        {
            Debug.LogError("MeshFilter component missing.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        angle = Mathf.Atan2(myVector.y, myVector.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0, 0, angle);
        mesh.Clear();
        updateMesh();


    }

    void updateMesh()
    {
        
        float arrowHeight = .3f;
        float headHeight = 0.8f;
        float headWidth = 0.7f;
        float arrowWidth = Mathf.Max(0, myVector.magnitude - headWidth); // Ensure non-negative value
        //print(arrowWidth);

        mesh.vertices = new Vector3[]
        {
            new Vector3 (0,arrowHeight,0),
            new Vector3 (arrowWidth,arrowHeight,0),
            new Vector3 (arrowWidth,headHeight,0),
            new Vector3 (arrowWidth + headWidth,0,0),
            new Vector3 (arrowWidth,-headHeight,0),
            new Vector3 (arrowWidth,-arrowHeight,0),
            new Vector3 (0,-arrowHeight,0),
        };

        mesh.triangles = new int[]
        {
            0,1,5, // body
            0,5,6, // body
            1,2,5, // arrow body to head
            2,3,4  // arrowhead
        };
        mesh.RecalculateNormals();
    }
}