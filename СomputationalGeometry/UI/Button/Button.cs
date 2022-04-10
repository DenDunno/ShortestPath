
public class Button
{
    public readonly ButtonView View;
    public readonly ButtonClick Click;

    public Button(ButtonView view, ButtonClick click)
    {
        View = view;
        Click = click;
    }
}