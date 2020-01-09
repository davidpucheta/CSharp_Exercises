using System;

namespace DbConnection
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private TimeSpan _timeOut;

        public DbConnection(string connectionString)
        {
            if (!string.IsNullOrEmpty(connectionString))
            {
                _connectionString = connectionString;
            } 
            else
            {
                throw new InvalidOperationException("Connection string is empty or null");
            }
        }

        public abstract void Open();

        public abstract void Close();

    }
}
