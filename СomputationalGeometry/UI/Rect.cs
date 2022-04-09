using OpenTK.Mathematics;

public class Rect
{
    public readonly Vector2i Location;
    public readonly Vector2i Size;

    public Rect(Vector2i location, Vector2i size)
    {
        Location = location;
        Size = size;
    }
}