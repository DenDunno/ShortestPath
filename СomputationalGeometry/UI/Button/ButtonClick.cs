
public class ButtonClick
{
    private readonly Rect _rect;
    private readonly Action _action;

    public ButtonClick(Rect rect, MouseInput mouseInput, Action action)
    {
        _rect = rect;
        _action = action;
        mouseInput.MousePressed += OnMousePressed;
    }

    private void OnMousePressed(Point mousePosition)
    {
        if (CheckMouseInButtonRect(mousePosition))
        {
            Console.WriteLine(mousePosition.X);
            _action?.Invoke();
        }
    }

    private bool CheckMouseInButtonRect(Point mousePosition)
    {
        return CheckBorder(mousePosition.X, _rect.Location.X, _rect.Size.X) &&
               CheckBorder(mousePosition.Y, _rect.Location.Y, _rect.Size.Y);
    }

    private bool CheckBorder(float input, float borderStart, float borderSize)
    {
        return input >= borderStart && input <= borderStart + borderSize;
    }
}