using System.Drawing;
using OpenTK.Graphics.OpenGL;

public class Obstacle : IDrawable
{
    private readonly List<Point> _points;
    private readonly List<Edge> _edges = new();

    public Obstacle(List<Point> points)
    {
        _points = points;
        ConnectEdges();
    }

    public IReadOnlyList<Point> Points => _points;
    public IReadOnlyList<Edge> Edges => _edges;
    
    private void ConnectEdges()
    {
        for (int i = 0; i < _points.Count - 1; ++i)
        {
            _edges.Add(new Edge(_points[i], _points[i + 1]));
        }
            
        _edges.Add(new Edge(_points.Last(), _points.First()));
    }

    void IDrawable.Draw()
    {
        GL.Begin(PrimitiveType.Polygon);
        GL.Color3(Color.Red);
            
        foreach (Point point in _points)    
        {
            GL.Vertex2(point.X, point.Y);
        }
            
        GL.End();
    }

    public bool IsInside(Edge visibleEdge)
    {
        return _points.Contains(visibleEdge.LeftPoint) && _points.Contains(visibleEdge.RightPoint) 
                                                       && !_edges.Any(edge => edge.Equals(visibleEdge));
    }
}