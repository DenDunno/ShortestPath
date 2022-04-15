
public class ShortestPathAlgorithm
{
    private readonly VisibilityGraph _visibilityGraph;
    private readonly AStarAlgorithm _aStarAlgorithm = new();
    
    public ShortestPathAlgorithm(VisibilityGraph visibilityGraph)
    {
        _visibilityGraph = visibilityGraph;
    }
    
    public List<Point> Evaluate(Point start, Point destination)
    {
        Graph visibilityGraph = _visibilityGraph.Build(start, destination);

        return _aStarAlgorithm.Evaluate(visibilityGraph, start, destination);
    }
}