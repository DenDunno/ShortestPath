using System.Collections.ObjectModel;

public class Renderer
{
    private readonly ReadOnlyCollection<IDrawable> _drawables;

    public Renderer(IDrawable[] drawables)
    {
        _drawables = new ReadOnlyCollection<IDrawable>(drawables);
    }

    public void Draw()
    {
        _drawables.ForEach(drawable => drawable.Draw());
    }
}