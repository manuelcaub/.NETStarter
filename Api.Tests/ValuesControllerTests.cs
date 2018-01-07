namespace Api.Tests
{
    using System.Linq;
    using Api.Controllers;
    using Microsoft.Extensions.Logging;
    using NSubstitute;
    using Xunit;

    public class ValuesControllerTests
    {
        private readonly ValuesController _controller;

        public ValuesControllerTests()
        {
            _controller = new ValuesController(Substitute.For<ILogger<ValuesController>>());
        }

        [Fact]
        public void ValuesController_GetAll_ShouldReturnValues()
        {
            Assert.Equal(2, _controller.Get().Count());
        }

        [Theory]
        [InlineData(1, "value1")]
        [InlineData(2, "value2")]
        [InlineData(3, "value3")]
        [InlineData(4, "value4")]
        public void ValuesController_GetOne_ShouldReturnValue(int id, string expectedValue)
        {
            Assert.Equal(expectedValue, _controller.Get(id));
        }
    }
}
