using System;

namespace DbConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbCommand;

        public DbCommand(DbConnection dbConnection, string dbCommand)
        {
            if (dbConnection != null && !string.IsNullOrEmpty(dbCommand))
            {
                _dbConnection = dbConnection;
                _dbCommand = dbCommand;
            }
            else
            {
                throw new InvalidOperationException("DB Connection and/or Db Command is null or empty");
            }
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Executing: {0}",_dbCommand);
            _dbConnection.Close();
        }

    }
}
