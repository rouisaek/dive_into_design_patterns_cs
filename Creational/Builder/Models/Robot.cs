namespace Builder.Models;

public class Robot
{
    public Core Core { get; set; }
    public Head Head { get; set; }
    public Arm LeftArm { get; set; }
    public Arm RightArm { get; set; }
    public Leg LeftLeg { get; set; }
    public Leg RightLeg { get; set; }
}