using System.Drawing;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

public class ScreenToWorldCoordinates
{
    public Point Evaluate(float x, float y)
    {
        int[] viewport = new int[4];
        GL.GetFloat(GetPName.ModelviewMatrix, out Matrix4 modelViewMatrix);
        GL.GetFloat(GetPName.ProjectionMatrix, out Matrix4 projectionMatrix);
        GL.GetInteger(GetPName.Viewport, viewport);
        Vector2 mouse = new Vector2(x, y);
        
        mouse.X = x;
        mouse.Y = viewport[3] - y;
        Vector4 vector = UnProject(ref projectionMatrix, modelViewMatrix, new Size(viewport[2], viewport[3]), mouse);

        return new Point(vector.X, vector.Y);
    }

    private Vector4 UnProject(ref Matrix4 projection, Matrix4 view, Size viewport, Vector2 mouse)
    {
        Vector4 vec;
        
        vec.X = 2.0f * mouse.X / viewport.Width - 1;
        vec.Y = -(2.0f * mouse.Y / viewport.Height - 1);
        vec.Z = 0;
        vec.W = 1.0f;
        
        Matrix4 viewInv = Matrix4.Invert(view);
        Matrix4 projInv = Matrix4.Invert(projection);

        Vector4.TransformColumn(in viewInv, in vec, out vec);
        Vector4.TransformColumn(in projInv, in vec, out vec);

        if (vec.W > float.Epsilon || vec.W < float.Epsilon)
        {
            vec.X /= vec.W;
            vec.Y /= vec.W;
            vec.Z /= vec.W;
        }
        
        return vec;
    }
}