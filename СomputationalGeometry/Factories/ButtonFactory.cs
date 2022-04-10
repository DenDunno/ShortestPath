using System.Drawing;
using OpenTK.Mathematics;

public class ButtonFactory
{
    private readonly MouseInput _mouseInput;
    private readonly Vector2i _buttonSize = new Vector2i(100, 100);
    
    public ButtonFactory(MouseInput mouseInput)
    {
        _mouseInput = mouseInput;
    }

    public Button Create(Color color, Vector2i location, Action onClickAction)
    {
        var rect = new Rect(location, _buttonSize);

        return new Button
        (
            new ButtonView(rect, color),
            new ButtonClick(rect, _mouseInput, onClickAction)
        );
    }
}