
var windowFactory = new WindowFactory();
var window = windowFactory.Create();

var obstacles = new Obstacles();
var camera = new Camera();
var startPoint = new KeyPoint(1.5f, -1, window.MouseState);
var destinationPoint = new KeyPoint(-1.5f, 1, window.MouseState);
var shortestPathLine = new ShortestPathLine(startPoint, destinationPoint);
var coordinateSystem = new CoordinateSystem();
var renderer = new Renderer(new IDrawable[]{coordinateSystem, obstacles, shortestPathLine, camera});

var obstaclesLoader = new ObstaclesLoader(obstacles);
var commands = new Commands(obstaclesLoader, coordinateSystem);
var keyboardInput = new KeyboardInput(window.KeyboardState, commands);
var mouseInput = new MouseInput(window.MouseState, camera);
var updateCycle = new UpdateCycle(window, new IUpdatable[]{keyboardInput, mouseInput, startPoint, destinationPoint, renderer});

updateCycle.Run();
window.Run();