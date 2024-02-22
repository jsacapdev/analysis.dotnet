using Analysis.Api.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace Analysis.Api.Tests;

public class WeatherForecastControllerTests
{
    [Fact]
    public void Get_Returns_OK()
    {
        var m_logger = new Mock<ILogger<WeatherForecastController>>();

        var controller = new WeatherForecastController(m_logger.Object);

        var result = controller.Get();

        Assert.NotNull(result);

        Assert.Equal(5, result.Count());
    }
}