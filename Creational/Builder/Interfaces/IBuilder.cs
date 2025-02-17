using Builder.Models;


namespace Builder.Interfaces;

public interface IBuilder
{
    // The builder interface specifies methods for creating the
    // different parts of the product objects.
    IBuilder SetShell(Shell shell);
    IBuilder SetHead(Head head);
    IBuilder SetLeftArm(Arm arm);
    IBuilder SetRightArm(Arm arm);
    IBuilder SetLeftLeg(Leg leg);
    IBuilder SetRightLeg(Leg leg);
}
