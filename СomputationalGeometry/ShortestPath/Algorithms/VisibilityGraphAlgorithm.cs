
public class VisibilityGraphAlgorithm
{
    private readonly Obstacles _obstacles;

    public VisibilityGraphAlgorithm(Obstacles obstacles)
    {
        _obstacles = obstacles;
    }
    
    public Graph Build(Point start, Point destination)
    {
        var graph = new Graph();
        graph.AddEdge(new Point(1, 2), new Point(2, 4));
        graph.AddEdge(new Point(2, -3), new Point(-1, -2));
        graph.AddEdge(new Point(-1, -2), new Point(5, 7));
        
        return graph;
    }
}