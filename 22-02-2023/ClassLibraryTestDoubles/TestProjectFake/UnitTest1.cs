using ClassLibraryTestDoubles;

namespace TestProjectFake
{
    public class UnitTest1
    {
        [Fact]
        public void GetTotalUsers_ShouldReturnTotalUsers_WhenCalledWithFakeDatabase()
        {
            // Arrange
           
            var fakeDatabase = new FakeDatabase(100); // Initialize fake database with 100 total users
            var calculator = new Calculator(fakeDatabase);

            // Act
            int totalUsers = calculator.GetTotalUsers();

            // Assert
            Assert.Equal(100, totalUsers); // Ensure that the correct total users count is returned
        }

    }
}