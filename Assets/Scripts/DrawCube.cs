using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCube : MonoBehaviour
{
    public Mesh mesh;
    public Material material;
    float angle = 0.0f;
    public void Update()
    {
        angle = angle + (90.0f * Time.deltaTime);
        if (angle > 360.0f)
            angle = 0.0f;
        Graphics.DrawMesh(mesh, Vector3.zero, Quaternion.AngleAxis(angle, Vector3.up), material, 0);
    }
}
