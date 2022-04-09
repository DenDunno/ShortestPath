
var windowFactory = new WindowFactory();
var window = windowFactory.Create();

var mouseInput = new MouseInput(window);
var renderer = new Renderer();

window.Run();