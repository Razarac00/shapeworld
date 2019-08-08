using ShapeWorld.Domain.Models;
using Xunit;

namespace ShapeWorld.Testing
{
    public class RectangleTests
    {
        [Fact]
        public void Test_Edges()
        {
            // arrange
            var rectangle = new Rectangle(); // var -- lazy instantiation; I'll be whatever you first tell me to be
            var expected = 4;

            // act
            var actual = rectangle.NumberOfEdges;

            // assert
            Assert.True(expected == actual);

        }
    }
}