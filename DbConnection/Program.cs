namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection sqlConnection = new OracleConnection("cnx:str");
            DbCommand dbCommand = new DbCommand(sqlConnection, "db:commmand");

            dbCommand.Execute();
        }
    }
}
