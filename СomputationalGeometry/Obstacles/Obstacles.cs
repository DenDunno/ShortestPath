using System.Drawing;
using OpenTK.Graphics.OpenGL;

public class Obstacles : IDrawable
{
    private List<List<Point>> _obstacles = new();

    public void SetPoints(List<List<Point>> obstacles)
    {
        _obstacles = obstacles;
    }

    void IDrawable.Draw()
    {
        foreach (List<Point> obstacle in _obstacles)
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