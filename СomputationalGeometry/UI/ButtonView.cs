using OpenTK.Mathematics;

public struct ButtonView : IDrawable
{
    public readonly Rect Rect;
    public readonly Color4 Background;
    public readonly ButtonText Text;

    public ButtonView(Rect rect, Color4 background, ButtonText text)
    {
        Rect = rect;
        Background = background;
        Text = text;
    }
    
    void IDrawable.Draw()
    {
    }
}