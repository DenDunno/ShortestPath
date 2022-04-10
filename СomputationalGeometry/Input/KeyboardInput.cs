using OpenTK.Windowing.GraphicsLibraryFramework;

public class KeyboardInput
{
    private readonly Window _window;
    private readonly Commands _commands;
    private bool _isAnyKeyDown;
    
    public KeyboardInput(Window window, Commands commands)
    {
        _window = window;
        _commands = commands;
    }

    public void Update()
    {
        KeyboardState state = _window.KeyboardState;

        if (_isAnyKeyDown == false)
        {
            _commands.TryInvokeCommand(state);
        }

        _isAnyKeyDown = state.IsAnyKeyDown;
    }
}