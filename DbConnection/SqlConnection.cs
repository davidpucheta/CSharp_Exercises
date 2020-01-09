namespace DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string cnxStr) : base(connectionString: cnxStr)
        {

        }

        public override void Close()
        {
            System.Console.WriteLine("Closing Sql Connection");
        }

        public override void Open()
        {
            System.Console.WriteLine("Opening Sql Connection");
        }
    }
}
