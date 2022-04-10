using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

public class Camera
{
    private Vector2 _position;
    private float _size = 1;
    private readonly int _width = 4;
    private readonly int _height = 3;

    public void Zoom(float delta)
    {
        _size += delta;
    }

    public void Translate(Vector2 delta)
    {
        _position += delta;
    }

    public void Draw()
    {
        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadIdentity();
        
        Matrix4 proj = Matrix4.CreateTranslation(new Vector3(-_position.X * _width, -_position.Y * _height, 0)) *
                       Matrix4.CreateOrthographic(_width * _size, _height * _size, 0, 1000);
        
        GL.LoadMatrix(ref proj);
        GL.MatrixMode(MatrixMode.Modelview);
    }
}