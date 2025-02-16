using Builder.Models;
using Builder.Repositories;

namespace Builder;

public class Application
{
    public static Robot BuilderRobot()
    {
        RobotBuilder builder = new();

        builder.AddCore(new Core(EShape.Square));
        builder.AddHead(new() { Shape = EShape.Circle });
        builder.AddLeftArm();
        builder.AddRightArm();
        builder.AddRightLeg();
        builder.AddLeftLeg();

        return builder.Build();
    }
}
