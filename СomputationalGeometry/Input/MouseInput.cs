using OpenTK.Mathematics;
using OpenTK.Windowing.GraphicsLibraryFramework;

public class MouseInput : IUpdatable
{
    private readonly MouseState _mouseState;
    private readonly Camera _camera;
    private float _zoomSpeed = 50;
    private float _translationSpeed = 2;
    
    public MouseInput(MouseState mouseState, Camera camera)
    {
        _mouseState = mouseState;
        _camera = camera;
    }

    void IUpdatable.Update(float deltaTime)
    {
        if (_mouseState.IsButtonDown(MouseButton.Button3))
        {
            var delta = new Vector2(-_mouseState.Delta.X, _mouseState.Delta.Y);
            _camera.Translate(_translationSpeed * delta * deltaTime);
        }
        
        _camera.Zoom(-_mouseState.ScrollDelta.Y * deltaTime * _zoomSpeed);
    }
}