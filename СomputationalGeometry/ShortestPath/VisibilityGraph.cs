
public class VisibilityGraph : IDrawable
{
    private readonly VisibilityGraphAlgorithm _visibilityGraphAlgorithm;
    private Graph _graph = new();
    
    public VisibilityGraph(Obstacles obstacles)
    {
        _visibilityGraphAlgorithm = new VisibilityGraphAlgorithm(obstacles);
    }

    public Graph Build(Point start, Point destination)
    {
        _graph = _visibilityGraphAlgorithm.Build(start, destination);
        
        return _graph;
    }

    void IDrawable.Draw()
    {
        _graph.Draw();
    }
}