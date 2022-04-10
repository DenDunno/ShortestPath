
var windowFactory = new WindowFactory();
var window = windowFactory.Create();
var renderer = new Renderer();
var obstacles = new Obstacles();
var obstaclesLoader = new ObstaclesLoader(obstacles);
var commands = new Commands(obstaclesLoader);
var keyboardInput = new KeyboardInput(window, commands);
var camera = new Camera();
var mouseInput = new MouseInput(window, camera);
var shortestPathLine = new ShortestPathLine(new Point(-1.5f, 1), new Point(1, -0.5f));

window.FrameRendering += deltaTime =>
{
    keyboardInput.Update();
    mouseInput.Update(deltaTime);
    renderer.Draw();
    camera.Draw();
};

renderer.AddElementsToDraw(new IDrawable[]{shortestPathLine, obstacles});
window.Run();