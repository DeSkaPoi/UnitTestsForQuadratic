
using Xunit;

namespace UnitTestsForQuadratic
{
    public class UnitTest1
    {
        private const double Epslon = 1e-7;
        [Fact]
        public void Test1()
        {
            var testData = Program.Solve(1, 0, -1);
            Assert.Equal(new double[] { 1, -1, }, testData);
        }

        [Fact]
        public void Test2()
        {
            var testData = Program.Solve(1, 0, 1);
            Assert.Empty(testData);
        }

        [Fact]
        public void Test3()
        {
            var testData = Program.Solve(1, 2, 1);
            Assert.Equal(new double[] { -1, -1 }, testData);
        }

        [Fact]
        public void Test4()
        {
            double a = 0.1;

            var b = Math.Abs(a) <= Epslon ? true : false;

            Assert.False(b);
            var testData = Program.Solve(a, 2, 1);
        }

        [Fact]
        public void Test5()
        {
            var testData = Program.Solve(0.9999999999, 4, 4);
            Assert.Equal(2, testData.Length);
            Assert.True(Math.Abs(testData[0] - testData[1]) <= Epslon);
        }

        [Fact]
        public void Test6()
        {
            var a = 0.111111111111;
            var b = 0.1;
            var c = double.MaxValue;

            Assert.True(!double.IsNaN(a) && !double.IsNaN(b) && !double.IsNaN(c));
            Assert.True(double.MaxValue >= a && a >= double.MinValue);
            Assert.True(double.MaxValue >= b && b >= double.MinValue);
            Assert.True(double.MaxValue >= c && c >= double.MinValue);


            var testData = Program.Solve(0.9999999999, 4, 4);
            
        }
    }
}