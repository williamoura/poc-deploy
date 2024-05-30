namespace PoC.Deploy.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var a = 1;
            var b = 2;
            // Act
            var result = a + b;
            // Assert
            Assert.Equal(3, result);
        }
    }
}