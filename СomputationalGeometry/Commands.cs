using OpenTK.Windowing.GraphicsLibraryFramework;

public class Commands
{
    private readonly List<Command> _commands;

    public Commands(ObstaclesLoader obstaclesLoader, CoordinateSystem coordinateSystem)
    {
        _commands = new List<Command>()
        {
            new(Keys.I, obstaclesLoader.Load),
            new(Keys.D, coordinateSystem.Toggle),
        };
    }

    public void TryInvokeCommand(KeyboardState keyboardState)
    {
        foreach (Command command in _commands)
        {
            if (keyboardState.IsKeyDown(command.Key))
            {
                command.Action();
            }
        }
    }
}