using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Mesh mesh;
    public Vector3 myVector = new Vector3(3, 4, 0);

    // Start is called before the first frame update
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
        mesh.Clear();
        updateMesh();
    }

    void updateMesh()
    {
        
        float arrowHeight = .5f;
        float headHeight = 1.5f;
        float headWidth = 2.0f;
        float arrowWidth = Mathf.Max(0, myVector.magnitude - headWidth); // Ensure non-negative value
        print(arrowWidth);

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