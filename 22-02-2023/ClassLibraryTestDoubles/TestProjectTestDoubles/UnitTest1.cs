using ClassLibraryTestDoubles;

namespace TestProjectTestDoubles
{
    
    public class UnitTest1
    {
        [Fact]
    public void Add_ShouldNotLogMessage_WhenCalledWithDummyLogger()
    {
        // Arrange
        var dummyLogger = new DummyLogger();
        var calculator = new Calculator(dummyLogger);

        // Act
        int result = calculator.Add(3, 5);

        // Assert
        Assert.Equal(8, result); // Ensure that the result is correct
        // Since we are using a dummy logger, no logging should occur
    }
       
    }
}