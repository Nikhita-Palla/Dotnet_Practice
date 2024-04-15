
using ClassLibraryTestDoubles;
using Moq;

namespace TestProjectMoq
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ShouldLogMessage_WhenCalledWithMockLogger()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var calculator = new Calculator(mockLogger.Object);

            // Act
            calculator.Add(3, 5);

            // Assert
            //mockLogger.Verify(l => l.Log("Subtracting 3 and 5")); //failed
            mockLogger.Verify(l=>l.Log("Adding 3 and 5"));
        }
    }
}