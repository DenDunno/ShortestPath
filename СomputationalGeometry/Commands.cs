using OpenTK.Windowing.GraphicsLibraryFramework;

public class Commands
{
    private readonly List<Command> _commands;

    public Commands(ObstaclesLoader obstaclesLoader)
    {
        _commands = new List<Command>()
        {
            new Command(Keys.I, obstaclesLoader.Load),
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