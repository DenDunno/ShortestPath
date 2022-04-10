using OpenTK.Graphics.OpenGL;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

public class Window : GameWindow
{
    private readonly Renderer _renderer;

    public Window(WindowSettings windowSettings, Renderer renderer) 
        : base(windowSettings.GameWindowSettings, windowSettings.NativeWindowSettings)
    {
        _renderer = renderer;
    }

    protected override void OnRenderFrame(FrameEventArgs args)
    {
        GL.Clear(ClearBufferMask.ColorBufferBit);
        
        _renderer.Draw();

        SwapBuffers();
        base.OnRenderFrame(args);
    }
}