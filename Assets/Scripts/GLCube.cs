using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLCube : MonoBehaviour
{
    public Material cubeMaterial;
    private float angleY = 0.0f;

    public void OnRenderObject()
    {
        if(cubeMaterial)
            cubeMaterial.SetPass(0);
        angleY = angleY + 70 * Time.deltaTime;
        if (angleY >= 360.0f)
            angleY = 0.0f;
        Quaternion rotation = Quaternion.Euler(0, angleY, 0);
        Matrix4x4 cubeTransform = Matrix4x4.TRS(Vector4.zero, rotation, new Vector3(1,1,1));

        GL.wireframe = true;
        GL.PushMatrix();
        // Set transformation matrix for drawing to
        // match our transform
        GL.MultMatrix(cubeTransform);

        // BACK
        GL.Begin(GL.QUADS);
        GL.Color(Color.blue);
        {
            GL.Vertex3(+0.5f, -0.5f, +0.5f);
            GL.Vertex3(-0.5f, -0.5f, +0.5f);
            GL.Vertex3(-0.5f, +0.5f, +0.5f);
            GL.Vertex3(+0.5f, +0.5f, +0.5f);
        }
        GL.End();
        // LEFT
        GL.Begin(GL.QUADS);
        GL.Color(Color.yellow);
        {
            GL.Vertex3(-0.5f, +0.5f, -0.5f);
            GL.Vertex3(-0.5f, +0.5f, +0.5f);
            GL.Vertex3(-0.5f, -0.5f, +0.5f);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);
        }
        GL.End();
        // RIGHT
        GL.Begin(GL.QUADS);
        GL.Color(Color.red);
        {
            GL.Vertex3(+0.5f, +0.5f, -0.5f);
            GL.Vertex3(+0.5f, +0.5f, +0.5f);
            GL.Vertex3(+0.5f, -0.5f, +0.5f);
            GL.Vertex3(+0.5f, -0.5f, -0.5f);
        }
        GL.End();
        // FRONT
        GL.Begin(GL.QUADS);
        GL.Color(Color.cyan);
        {
            GL.Vertex3(+0.5f, -0.5f, -0.5f);
            GL.Vertex3(+0.5f, +0.5f, -0.5f);
            GL.Vertex3(-0.5f, +0.5f, -0.5f);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);
        }
        GL.End();
        // TOP
        GL.Begin(GL.QUADS);
        GL.Color(Color.white);
        {
            GL.Vertex3(+0.5f, +0.5f, +0.5f);
            GL.Vertex3(-0.5f, +0.5f, +0.5f);
            GL.Vertex3(-0.5f, +0.5f, -0.5f);
            GL.Vertex3(+0.5f, +0.5f, -0.5f);
        }
        // BOTTOM
        GL.Begin(GL.QUADS);
        GL.Color(Color.black);
        {
            GL.Vertex3(+0.5f, -0.5f, +0.5f);
            GL.Vertex3(+0.5f, -0.5f, -0.5f);
            GL.Vertex3(-0.5f, -0.5f, -0.5f);
            GL.Vertex3(-0.5f, -0.5f, +0.5f);
        }
        GL.End();
        GL.PopMatrix();
    }
}
