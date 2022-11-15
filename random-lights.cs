List<IMyInteriorLight> lights = new List<IMyInteriorLight>();
Random random = new Random();

public Program()
{
    Runtime.UpdateFrequency = UpdateFrequency.Update10;
    GridTerminalSystem.GetBlocksOfType<IMyInteriorLight>(lights);
}

public void Main(string argument, UpdateType updateSource)
{
    foreach (var light in lights)
    {
        int r = random.Next(0, 256);
        int g = random.Next(0, 256);
        int b = random.Next(0, 256);
        light.Color = new VRageMath.Color(r, g, b);
    } 
}
