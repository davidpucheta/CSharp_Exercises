namespace Workflow
{
    class CallAPI : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Calling third party video encoding service");
        }
    }

}
