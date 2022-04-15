using OpenTK.Mathematics;

public class ShortestPath : IDrawable
{
    private readonly KeyPoint _start;
    private readonly KeyPoint _destination;
    private readonly ShortestPathAlgorithm _shortestPathAlgorithm;

    public ShortestPath(KeyPoint startPoint, KeyPoint destinationPoint, VisibilityGraph visibilityGraph)
    {
        _start = startPoint;
        _destination = destinationPoint;
        _shortestPathAlgorithm = new ShortestPathAlgorithm(visibilityGraph);
    }

    void IDrawable.Draw()
    {
        List<Point> pathPoints = _shortestPathAlgorithm.Evaluate(_start.Point, _destination.Point);

        DrawPathLine(pathPoints);
        DrawKeyCircles();
        DrawPathCircles(pathPoints);
    }

    private void DrawKeyCircles()
    {
        GLHelper.DrawCircle(_start.Point, 0.1f, Color4.Lime);
        GLHelper.DrawCircle(_destination.Point, 0.1f, Color4.Lime);
    }

    private void DrawPathLine(List<Point> pathPoints)
    {
        var path = new List<Point>(pathPoints);
        path.Insert(0, _start.Point);
        path.Add(_destination.Point);
        
        GLHelper.DrawLine(path, 3f, Color4.Aqua);
    }

    private void DrawPathCircles(List<Point> pathPoints)
    {
        foreach (Point pathPoint in pathPoints)
        {
            GLHelper.DrawCircle(pathPoint, 0.05f, Color4.Yellow);
        }
    }
}