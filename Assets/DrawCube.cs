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
        angle = Mathf.Clamp(angle + (50.0f * Time.deltaTime), 0.0f, 360.0f);
        Graphics.DrawMesh(mesh, Vector3.zero, Quaternion.AngleAxis(angle, Vector3.up), material, 0);
    }
}
