using OpenTK.Mathematics;

public class CameraSettings
{
    public readonly Vector3i Position;
    public readonly int Size;

    public CameraSettings(Vector3i position, int size)
    {
        Position = position;
        Size = size;
    }
}