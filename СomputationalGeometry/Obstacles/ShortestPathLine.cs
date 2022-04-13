using OpenTK.Mathematics;

public class ShortestPathLine : IDrawable
{
    private readonly Point _start;
    private readonly Point _destination = new(1, -0.5f);
    private readonly ShortestPathAlgorithm _shortestPathAlgorithm = new();
    
    public ShortestPathLine(Point start)
    {
        _start = start;
    }

    void IDrawable.Draw()
    {
        List<Point> pathPoints = _shortestPathAlgorithm.Evaluate(_start, _destination);

        DrawPathLine(pathPoints);
        DrawKeyCircles();
        DrawPathCircles(pathPoints);
    }

    private void DrawKeyCircles()
    {
        GLHelper.DrawCircle(_start, 0.05f, Color4.Lime);
        GLHelper.DrawCircle(_destination, 0.05f, Color4.Lime);
    }

    private void DrawPathLine(List<Point> pathPoints)
    {
        var path = new List<Point>(pathPoints);
        path.Insert(0, _start);
        path.Add(_destination);
        
        GLHelper.DrawLine(path, 0.02f, Color4.Aqua);
    }

    private void DrawPathCircles(List<Point> pathPoints)
    {
        foreach (Point pathPoint in pathPoints)
        {
            GLHelper.DrawCircle(pathPoint, 0.025f, Color4.Yellow);
        }
    }
}