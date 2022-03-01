using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using PipelineApp.Controllers;
using Xunit;

namespace PopelineAppTests
{
    public class WeatherForecastControllerTests
    {
        private readonly Mock<ILogger<WeatherForecastController>> _loggerMoq = new Mock<ILogger<WeatherForecastController>>();
        public WeatherForecastControllerTests()
        {
        }

        [Fact]
        public void SayHi_Success()
        {
            var controller = new WeatherForecastController(_loggerMoq.Object);

            var result = controller.SayHi();

            result.Should().Be("Hello Word!");
        }

        [Fact]
        public void SayHi_Fail()
        {
            var controller = new WeatherForecastController(_loggerMoq.Object);

            var result = controller.SayHi();

            result.Should().NotBe("Foo");
        }
    }
}