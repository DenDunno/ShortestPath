
public class ObstaclesLoader
{
    private readonly ObstacleParser _obstacleParser;
    private readonly Obstacles _obstacles;

    public ObstaclesLoader(Obstacles obstacles)
    {
        _obstacleParser = new ObstacleParser("obstacles.json");
        _obstacles = obstacles;
    }

    public void Load()
    {
        _obstacles.SetPoints(_obstacleParser.Parse());
    }
}