using Itmo.ObjectOrientedProgramming.Lab1;
using Itmo.ObjectOrientedProgramming.Lab1.RouteParts;
using Xunit;

namespace Lab1.Tests;

public class RouteTests
{
    private readonly MagneticPath magneticPath;

    public RouteTests()
    {
        magneticPath = new MagneticPath();
    }

    [Theory]
    [InlineData(-500, true)]
    [InlineData(500, true)]
    [InlineData(1000, false)]
    [InlineData(2000, false)]
    public void Scenario1(int mass, bool isSuccess)
    {
        // arrange
        var train = new Train(mass);

        // act
        Result result = magneticPath.Pass(train);

        // assert
        Assert.Equal(isSuccess, result.IsSuccess);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-11)]
    [InlineData(-1000)]
    public void TrainDoesntAllowNegativeMass(int mass)
    {
        Assert.Throws<ArgumentException>(() => new Train(mass));
    }
}
