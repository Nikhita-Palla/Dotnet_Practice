using ClassLibraryTestDoubles;

namespace TestProjectStub
{
    public class StubDemo
    {
        [Fact]
        public void GetTotalUsers_ShouldReturnTotalUsers_WhenCalledWithStubDatabase()
        {
            // Arrange
            var stubDatabase = new StubDatabase();
            var calculator = new Calculator(stubDatabase);

            // Act
            int totalUsers = calculator.GetTotalUsers();

            // Assert
            Assert.Equal(100, totalUsers); // Ensure that the correct total users are returned
                                           // Since we are using a stub database, no actual database call is made
        }
    }
}