using System.Drawing;
using OpenTK.Graphics.OpenGL;

public class ButtonView : IDrawable
{
    public readonly Rect Rect;
    public readonly Color Background;

    public ButtonView(Rect rect, Color background)
    {
        Rect = rect;
        Background = background;
    }
    
    void IDrawable.Draw()
    {
        GL.Rect(10, 10, 10, 10);
        // GL.Color3(Background);
        // GL.Begin(PrimitiveType.Quads);
        // GL.Vertex2(-0.5f, -0.5f);
        // GL.Vertex2( 0.5f, -0.5f);
        // GL.Vertex2( 0.5f,  0.5f);
        // GL.Vertex2(-0.5f,  0.5f);
        // GL.End();
    }
}