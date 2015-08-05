using System;
using Xunit;

namespace Mindbox.Math.Area.Test
{
    public class AreaTriangleTest  :IDisposable
    {
        private MathArea mathArea;

        public AreaTriangleTest()
        {
            mathArea = new MathArea();
        }

        [Fact]
        public void ShouldBeCreatedClass()
        {
            Assert.NotNull(mathArea);
        }

        [Fact]
        public void ShouldBeReturnAreaTriangleWithInt()
        {
            var result = mathArea.GetAreaTriangle(2, 2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void ShouldBeReturnAreaTriangleWithDouble()
        {
            var result = mathArea.GetAreaTriangle(0.5, 0.5);

            Assert.Equal(0.125, result);
        }

        [Fact]
        public void ShouldBeReturnZeroAreaTriangleWithNegative()
        {
            var result = mathArea.GetAreaTriangle(-1, 1);

            Assert.Equal(0, result);
        }

        public void Dispose()
        {
            mathArea = null;
        }
    }
}