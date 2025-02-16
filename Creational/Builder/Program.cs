using Builder;
using Builder.Models;

Robot robot = Application.BuilderRobot();

Console.WriteLine($"Name: {robot.Core.Name}");
Console.WriteLine($"Defence: {robot.Core.Defence}");
Console.WriteLine($"Vertices: {robot.Core.Vertices}");