namespace DbConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Close()
        {
            System.Console.WriteLine("Closing connection to Oracle Database");
        }

        public override void Open()
        {
            System.Console.WriteLine("Opening connection to Oracle Database");
        }
    }
}
