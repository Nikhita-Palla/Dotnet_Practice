using ClassLibraryTestDoubles;

namespace TestProjectSpy
{
    public class UnitTest1
    {
        [Fact]
        public void TrackActivity_ShouldLogActivity_WhenCalledWithSpyLogger()
        {
            // Arrange
            var spyLogger = new SpyLogger();
            var calculator = new Calculator(spyLogger);

            // Act
            calculator.Add(2,3);
            //spyLogger.TrackActivity("Added 2 and 3");
           

            // Assert
            Assert.True(spyLogger.WasLogged("Adding 2 and 3")); // Ensure that the activity was logged
        }
    }
}