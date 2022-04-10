
public class Renderer
{
    private readonly List<IDrawable> _drawables = new();
    
    public void Draw()
    {
        _drawables.ForEach(drawable => drawable.Draw());
    }

    public void AddElementToDraw(IDrawable drawable)
    {
        _drawables.Add(drawable);
    }
}