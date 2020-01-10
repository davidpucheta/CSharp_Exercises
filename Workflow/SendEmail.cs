namespace Workflow
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Notifying video owner");
        }
    }

}
