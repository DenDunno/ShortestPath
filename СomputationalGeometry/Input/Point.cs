using Newtonsoft.Json;
using OpenTK.Mathematics;

public class Point
{
    public readonly float X;
    public readonly float Y;

    public Point(Vector2 position)
    {
        X = position.X;
        Y = position.Y;
    }
    
    [JsonConstructor]
    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}