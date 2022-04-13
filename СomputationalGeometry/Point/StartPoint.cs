using OpenTK.Windowing.GraphicsLibraryFramework;

public class StartPoint : IUpdatable
{
    private readonly MouseState _mouseState;
    private readonly ScreenToWorldCoordinates _screenToWorldCoordinates = new();
    
    public StartPoint(float x, float y, MouseState mouseState)
    {
        Point = new Point(x, y);
        _mouseState = mouseState;
    }

    public Point Point { get; private set; }

    public void ToggleLockToMouse()
    {
        
    }

    void IUpdatable.Update(float deltaTime)
    {
        Point = _screenToWorldCoordinates.Evaluate(_mouseState.X, _mouseState.Y);
    }
}