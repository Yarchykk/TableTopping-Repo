using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class HexMesh : MonoBehaviour
{

    //Completed using the CatLikeCoding Hex Map tutorial
    //https://catlikecoding.com/unity/tutorials/hex-map/part-1/

    Mesh hexMesh;
    List<Vector3> vertices;
    List<int> triangles;
    MeshCollider meshCollider;
    List<Color> colors;

    void Awake()
    {
        GetComponent<MeshFilter>().mesh = hexMesh = new Mesh();
        meshCollider = gameObject.AddComponent<MeshCollider>();
        hexMesh.name = "Hex Mesh";
        vertices = new List<Vector3>();
        colors = new List<Color>();
        triangles = new List<int>();
    }

    public void Triangulate(HexCell[] cells)
    {
        hexMesh.Clear();
        vertices.Clear();
        colors.Clear();
        triangles.Clear();

        for (int i = 0; i < cells.Length; i++)
        {
            Triangulate(cells[i]);
        }
        hexMesh.vertices = vertices.ToArray();
        hexMesh.colors = colors.ToArray();
        hexMesh.triangles = triangles.ToArray();
        hexMesh.RecalculateNormals();
        meshCollider.sharedMesh = hexMesh;
    }

    //Adds triangles around center based on cell location
    void Triangulate(HexCell cell)
    {
        Vector3 center = cell.transform.localPosition;
        for(int i = 0; i < 6; i++) {
            AddTriangle(
               center,
               center + HexMetrics.corners[i],
               center + HexMetrics.corners[i+1]
           );
           AddTriangleColor(cell.color);
        }
       
    }

    //Adds color to triangles
    void AddTriangleColor(Color color)
    {
        colors.Add(color);
        colors.Add(color);
        colors.Add(color);
    }

    //Renders hexagon as 6 triangles.
    void AddTriangle(Vector3 v1, Vector3 v2, Vector3 v3)
    {
        int vertexIndex = vertices.Count;
        vertices.Add(v1);
        vertices.Add(v2);
        vertices.Add(v3);
        triangles.Add(vertexIndex);
        triangles.Add(vertexIndex + 1);
        triangles.Add(vertexIndex + 2);
    }
}