using System;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivityToWorkflow(new UploadVideo());
            workflow.AddActivityToWorkflow(new CallAPI());
            workflow.AddActivityToWorkflow(new SendEmail());
            workflow.AddActivityToWorkflow(new UpdateVideoStatus());

            workflow.Run();
        }
    }
}
