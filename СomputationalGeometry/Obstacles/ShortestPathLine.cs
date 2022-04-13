using OpenTK.Mathematics;

public class ShortestPathLine : IDrawable
{
    private readonly Point _start;
    private readonly Point _destination = new(1, -0.5f);

    public ShortestPathLine(Point start)
    {
        _start = start;
    }

    void IDrawable.Draw()
    {
        GLHelper.DrawCircle(_start, 0.05f, Color4.Lime);
        GLHelper.DrawCircle(_destination, 0.05f, Color4.Lime);
    }
}