using System.Drawing;
using OpenTK.Mathematics;

var renderer = new Renderer();
var windowFactory = new WindowFactory(renderer);
var window = windowFactory.Create();
var mouseInput = new MouseInput(window);
var buttonFactory = new ButtonFactory(mouseInput);
var importButton = buttonFactory.Create(Color.Green, new Vector2i(100, 100), null);

renderer.DrawElements(new IDrawable []{importButton.View});
window.Run();