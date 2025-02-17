using Builder.Models;
using Builder.Repositories;

namespace Builder;

public class Application
{
    public static Robot BuilderRobot()
    {
        var builder = new RobotBuilder();

        builder
        .SetShell(new(EShape.Triangle))
        .SetHead(new() { Shape = EShape.Square })
        .SetLeftArm(new())
        .SetRightArm(new())
        .SetRightLeg(new())
        .SetLeftLeg(new());

        return builder.Build();
    }
}
