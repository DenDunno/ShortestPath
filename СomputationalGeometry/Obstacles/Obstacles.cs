using System.Drawing;
using OpenTK.Graphics.OpenGL;

public class Obstacles : IDrawable
{
    public List<List<Point>> Points { get; private set; } = new();

    public void SetPoints(List<List<Point>> points)
    {
        Points = points;
    }

    void IDrawable.Draw()
    {
        foreach (List<Point> obstacle in Points)
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.Red);
            
            foreach (Point point in obstacle)    
            {
                GL.Vertex2(point.X, point.Y);
            }
            
            GL.End();
        }
    }
}