
public class Renderer
{
    private readonly List<IDrawable> _drawables = new();
    
    public void Draw()
    {
        _drawables.ForEach(drawable => drawable.Draw());
    }

    public void DrawElements(IDrawable[] drawables)
    {
        _drawables.AddRange(drawables);
    }

    public void EraseElements(IDrawable[] drawablesToRemove)
    {
        foreach (IDrawable drawableToRemove in drawablesToRemove)
        {
            _drawables.Remove(drawableToRemove);
        }
    }
}