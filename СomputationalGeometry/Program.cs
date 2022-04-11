
var windowFactory = new WindowFactory();
var window = windowFactory.Create();

var obstacles = new Obstacles();
var camera = new Camera();
var shortestPathLine = new ShortestPathLine(new Point(-1.5f, 1), new Point(1, -0.5f));
var coordinateSystem = new CoordinateSystem();
var renderer = new Renderer(new IDrawable[]{coordinateSystem, obstacles, shortestPathLine, camera});

var obstaclesLoader = new ObstaclesLoader(obstacles);
var commands = new Commands(obstaclesLoader, coordinateSystem);
var keyboardInput = new KeyboardInput(window, commands);
var mouseInput = new MouseInput(window, camera);

window.FrameRendering += deltaTime =>
{
    keyboardInput.Update();
    mouseInput.Update(deltaTime);
    renderer.Draw();
};

window.Run();