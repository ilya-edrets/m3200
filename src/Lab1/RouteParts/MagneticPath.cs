namespace Itmo.ObjectOrientedProgramming.Lab1.RouteParts;

public class MagneticPath : IRoutePart
{
    public Result Pass(Train train)
    {
        return new Result
        {
            IsSuccess = train.Mass < 1000,
        };
    }
}