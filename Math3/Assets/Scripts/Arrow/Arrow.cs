using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Mesh mesh;
    public Vector3 meshVector = new Vector3(0,0,0);
    private void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        UpdateMesh();
    }

    void UpdateMesh()
    {
        mesh.Clear();
        
        float arrowHeight =.5f;
        float arrowWidth =3;
        float headHeight = 1.5f;
        float headWidth =2f;
        //float arrowWidth = Mathf.Clamp(0,meshVector.magnitude,0) * 2 ;
        
        mesh.vertices = new Vector3[]
        {
            new Vector3(0, arrowHeight, 0),
            new Vector3(arrowWidth, arrowHeight, 0),
            new Vector3(arrowWidth, headHeight, 0),
            new Vector3(arrowWidth + headWidth,0,0),
            new Vector3(arrowWidth,-headHeight,0),
            new Vector3(arrowWidth,-arrowHeight,0),
            new Vector3(0,-arrowHeight,0)
        };

        mesh.triangles = new int[]
        {
            0,1,5,
            0,5,6,
            2,3,4
        };
        mesh.RecalculateNormals();
    }
}
