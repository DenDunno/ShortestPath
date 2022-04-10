using OpenTK.Mathematics;

public class ShortestPathLine : IDrawable
{
    private readonly Point _start;
    private readonly Point _destination;

    public ShortestPathLine(Point start, Point destination)
    {
        _start = start;
        _destination = destination;
    }

    void IDrawable.Draw()
    {
        GLHelper.DrawCircle(_start, 0.05f, Color4.Lime);
        GLHelper.DrawCircle(_destination, 0.05f, Color4.Lime);
    }
}