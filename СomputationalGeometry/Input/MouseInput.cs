using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;

public class MouseInput
{
    private readonly Window _window;
    private readonly Camera _camera;
    private float _zoomSpeed = 50;
    
    public MouseInput(Window window, Camera camera)
    {
        _window = window;
        _camera = camera;
    }

    public void Update(float deltaTime)
    {
        MouseState? mouseState = _window.MouseState;

        if (mouseState.IsButtonDown(MouseButton.Button3))
        {
            var delta = new Vector2(-mouseState.Delta.X, mouseState.Delta.Y);
            _camera.Translate(delta * deltaTime);
        }
        
        _camera.Zoom(-mouseState.ScrollDelta.Y * deltaTime * _zoomSpeed);
    }
}