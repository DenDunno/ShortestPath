using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

public class WindowFactory
{
    private readonly GameWindowSettings _gameWindowSettings;
    private readonly NativeWindowSettings _nativeWindowSettings;

    public WindowFactory()
    {
        _gameWindowSettings = new GameWindowSettings();
        _nativeWindowSettings = new NativeWindowSettings()
        {
            Size = new Vector2i(1200, 800),
            Location = new Vector2i(350, 150),
            Title = "Computational geometry",
            WindowBorder = WindowBorder.Fixed,
            Flags = ContextFlags.ForwardCompatible,
            Profile = ContextProfile.Core,
            API = ContextAPI.OpenGL
        };
    }
    
    public Window Create()
    {
        return new Window(_gameWindowSettings, _nativeWindowSettings);
    }
}