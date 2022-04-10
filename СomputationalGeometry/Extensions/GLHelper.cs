using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

public static class GLHelper
{
    public static void DrawCircle(Point point, float radius, Color4 color)
    {
        GL.Enable(EnableCap.Blend);
        GL.Begin(PrimitiveType.TriangleFan);
        GL.Color4(color);

        GL.Vertex2(point.X, point.Y);
        for (int i = 0; i < 360; i++)
        {
            GL.Vertex2(point.X + Math.Cos(i) * radius, point.Y + Math.Sin(i) * radius);
        }

        GL.End();
        GL.Disable(EnableCap.Blend);
    }
}