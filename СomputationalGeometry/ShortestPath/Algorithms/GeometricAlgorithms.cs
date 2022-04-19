
public static class GeometricAlgorithms
{
    public static bool IsLineIntersect(Edge edge1, Edge edge2)
    {
        float x1 = edge1.LeftPoint.X;
        float y1 = edge1.LeftPoint.Y;
        float x2 = edge1.RightPoint.X;
        float y2 = edge1.RightPoint.Y;
        float x3 = edge2.LeftPoint.X;
        float y3 = edge2.LeftPoint.Y;
        float x4 = edge2.RightPoint.X;
        float y4 = edge2.RightPoint.Y;

        float denominator = (y4 - y3) * (x1 - x2) - (x4 - x3) * (y1 - y2);
        
        if (denominator == 0 || IsChain(edge1, edge2))
        {
            return false;
        }

        float numeratorA = (x4 - x2) * (y4 - y3) - (x4 - x3) * (y4 - y2);
        float numeratorB = (x1 - x2) * (y4 - y2) - (x4 - x2) * (y1 - y2);
            
        float uA = numeratorA / denominator;
        float uB = numeratorB / denominator;

        return (uA is >= 0 and <= 1) && (uB is >= 0 and <= 1);
    }

    private static bool IsChain(Edge edge1, Edge edge2)
    {
        return edge1.LeftPoint.Equals(edge2.LeftPoint) || edge1.LeftPoint.Equals(edge2.RightPoint) ||
               edge1.RightPoint.Equals(edge2.LeftPoint) || edge1.RightPoint.Equals(edge2.RightPoint);
    }
}