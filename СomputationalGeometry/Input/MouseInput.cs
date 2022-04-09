using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;


public class MouseInput
{
    private readonly Window _window;
    public event Action<Point> MousePressed = null!;
    
    public MouseInput(Window window)
    {
        _window = window;
        window.MouseDown += InvokeMouseEvent;
    }

    private void InvokeMouseEvent(MouseButtonEventArgs mouseButtonEventArgs)
    {
        if (mouseButtonEventArgs.Button == MouseButton.Button1)
        {
            MousePressed?.Invoke(new Point(_window.MousePosition));
        }
    }
}