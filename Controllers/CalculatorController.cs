using Microsoft.AspNetCore.Mvc;

namespace DevopsLearn.Controllers;

/// <summary>
/// Provides simple arithmetic endpoints for demo and testing purposes.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    /// <summary>
    /// Returns the sum of two integers.
    /// </summary>
    /// <param name="a">First integer value.</param>
    /// <param name="b">Second integer value.</param>
    /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
    [HttpGet("add")]
    public ActionResult<int> Add([FromQuery] int a, [FromQuery] int b)
    {
        return Ok(a + b);
    }

    /// <summary>
    /// Divides a numerator by a denominator.
    /// </summary>
    /// <param name="numerator">The value to divide.</param>
    /// <param name="denominator">The divisor value.</param>
    /// <returns>The division result or a bad request when denominator is zero.</returns>
    [HttpGet("divide")]
    public ActionResult<double> Divide([FromQuery] double numerator, [FromQuery] double denominator)
    {
        if (denominator is 0)
        {
            return BadRequest("Denominator must not be zero.");
        }

        return Ok(numerator / denominator);
    }
}