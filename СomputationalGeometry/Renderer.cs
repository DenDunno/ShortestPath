
public class Renderer
{
    public void Draw(IDrawable[] drawables)
    {
        drawables.ForEach(drawable => drawable.Draw());
    }
}