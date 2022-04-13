
var windowFactory = new WindowFactory();
var window = windowFactory.Create();

var obstacles = new Obstacles();
var camera = new Camera();
var shortestPathLine = new ShortestPathLine(new Point(-1.5f, 1));
var coordinateSystem = new CoordinateSystem();
var renderer = new Renderer(new IDrawable[]{coordinateSystem, obstacles, shortestPathLine, camera});

var obstaclesLoader = new ObstaclesLoader(obstacles);
var commands = new Commands(obstaclesLoader, coordinateSystem);
var keyboardInput = new KeyboardInput(window.KeyboardState, commands);
var mouseInput = new MouseInput(window.MouseState, camera);
var updateCycle = new UpdateCycle(window, new IUpdatable[]{keyboardInput, mouseInput, renderer , new StartPoint(0,0, window.MouseState)});

updateCycle.Run();
window.Run();