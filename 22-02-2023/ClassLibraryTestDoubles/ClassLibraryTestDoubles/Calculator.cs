namespace ClassLibraryTestDoubles
{
    public interface ILogger
    {
        void Log(string message);
        bool WasLogged(string message);
    }
    public class DummyLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }


        bool ILogger.WasLogged(string message)
        {
            throw new NotImplementedException();
        }
    }

    public interface IDatabase
    {
        int GetTotalUsers();
    }

    public class StubDatabase : IDatabase
    {
        public int GetTotalUsers()
        {
            // Stub implementation: return a predetermined value
            return 100;
        }
    }

    public class FakeDatabase : IDatabase
    {
        private int totalUsers;

        public FakeDatabase(int totalUsers)
        {
            this.totalUsers = totalUsers;
        }

        public int GetTotalUsers()
        {
            return totalUsers;
        }
    }


    public class SpyLogger : ILogger
    {
        private List<string> loggedMessages = new List<string>();

        public void Log(string message)
        {
            loggedMessages.Add(message);
        }

        public bool WasLogged(string message)
        {
            return loggedMessages.Contains(message);
        }

        
    }

    public class Calculator
    {
        private readonly ILogger logger;
        private readonly IDatabase database;

        public Calculator(ILogger logger)
        {
            this.logger = logger;
        }

        public Calculator(IDatabase database) 
        {
            this.database = database;
        }
        public Calculator()
        {

        }

        public int Add(int a, int b)
        {
            logger.Log($"Adding {a} and {b}");
            return a + b;
        }

        public int GetTotalUsers()
        {
            return database.GetTotalUsers();
        }
    }

}
