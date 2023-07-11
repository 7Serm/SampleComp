using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var mesh  = new Mesh();
        mesh.SetVertices(new Vector3[] { new Vector3(0f, 0f, 9f), new Vector3(5f, 0f, -7), new Vector3(-3f, 0f, -5f) });
        mesh.SetTriangles(new int[] {0,1,2},0);
        var filter = GetComponent<MeshFilter>();
        filter.sharedMesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
