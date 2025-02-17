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

    public IBuilder SetShell(Shell core)
    {
        _robot.Core = core;
        return this;
    }

    public IBuilder SetHead(Head head)
    {
        _robot.Head = head;
        return this;
    }

    public IBuilder SetLeftArm(Arm arm)
    {
        _robot.LeftArm = arm;
        return this;
    }

    public IBuilder SetRightArm(Arm arm)
    {
        _robot.RightArm = arm;
        return this;
    }

    public IBuilder SetLeftLeg(Leg leg)
    {
        _robot.LeftLeg = leg;
        return this;
    }

    public IBuilder SetRightLeg(Leg leg)
    {
        _robot.RightLeg = leg;
        return this;
    }
}