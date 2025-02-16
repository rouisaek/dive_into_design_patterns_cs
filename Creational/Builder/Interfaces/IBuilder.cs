using Builder.Models;

namespace Builder.Interfaces;

public interface IBuilder
{
    // The builder interface specifies methods for creating the
    // different parts of the product objects.
    void AddCore(Core core);
    void AddHead(Head head);
    void AddLeftArm();
    void AddRightArm();
    void AddLeftLeg();
    void AddRightLeg();
}
