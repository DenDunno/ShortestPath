
public class ButtonFactory
{
    private readonly MouseInput _mouseInput;

    public ButtonFactory(MouseInput mouseInput)
    {
        _mouseInput = mouseInput;
    }

    public Button Create(ButtonView buttonView, Action onClickAction)
    {
        return new Button(buttonView, new ButtonClick(buttonView.Rect, _mouseInput, onClickAction));
    }
}