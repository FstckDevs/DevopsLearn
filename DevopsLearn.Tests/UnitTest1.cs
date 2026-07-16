using DevopsLearn.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DevopsLearn.Tests;

public class CalculatorControllerTests
{
    [Fact]
    public void Add_ReturnsExpectedSum()
    {
        var controller = new CalculatorController();

        var result = controller.Add(5, 7);

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        Assert.Equal(12, Assert.IsType<int>(okResult.Value));
    }

    [Fact]
    public void Divide_WithZeroDenominator_ReturnsBadRequest()
    {
        var controller = new CalculatorController();

        var result = controller.Divide(10, 0);

        var badRequest = Assert.IsType<BadRequestObjectResult>(result.Result);
        Assert.Equal("Denominator must not be zero.", Assert.IsType<string>(badRequest.Value));
    }

    [Fact]
    public void Divide_WithValidDenominator_ReturnsQuotient()
    {
        var controller = new CalculatorController();

        var result = controller.Divide(9, 3);

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        Assert.Equal(3d, Assert.IsType<double>(okResult.Value));
    }
}
