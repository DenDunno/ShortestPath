using OpenTK.Mathematics;

public class Graph : IDrawable
{
    private List<Edge> _edges = new();
    
    public void AddEdge(Point point1, Point point2)
    {
        _edges.Add(new Edge(point1, point2));
    }

    public void Draw()
    {
        foreach (Edge edge in _edges)
        {
            GLHelper.DrawLine(new List<Point>(){edge.LeftPoint, edge.RightPoint}, 0.01f, Color4.Yellow);
        }
        
        foreach (Edge edge in _edges)
        {
            GLHelper.DrawCircle(edge.LeftPoint, 0.05f, Color4.Blue);
            GLHelper.DrawCircle(edge.RightPoint, 0.05f, Color4.Blue);
        }
    }
}