using Builder.Interfaces;
using Builder.Models;

namespace Builder.Repositories;

public class RobotBuilder : IBuilder
{
    private Robot _robot;

    public RobotBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _robot = new Robot();
    }

    public Robot Build()
    {
        var robot = _robot;
        Reset();
        return robot;
    }

    public void AddCore(Core core)
    {
        _robot.Core = core;
    }

    public void AddHead(Head head)
    {
        _robot.Head = head;
    }

    public void AddLeftArm()
    {

    }

    public void AddLeftLeg()
    {

    }

    public void AddRightArm()
    {

    }

    public void AddRightLeg()
    {

    }
}
