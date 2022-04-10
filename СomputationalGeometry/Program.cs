
var windowFactory = new WindowFactory();
var window = windowFactory.Create();
var renderer = new Renderer();
var obstacles = new Obstacles();
var obstaclesLoader = new ObstaclesLoader(obstacles);
var commands = new Commands(obstaclesLoader);
var keyboardInput = new KeyboardInput(window, commands);
var camera = new Camera();
var mouseInput = new MouseInput(window, camera);

window.FrameRendering += deltaTime =>
{
    keyboardInput.Update();
    mouseInput.Update(deltaTime);
    renderer.Draw();
    camera.Draw();
};

renderer.AddElementToDraw(obstacles);
window.Run();