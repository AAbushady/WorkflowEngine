// The goal of this activity was to show the polymorphic behavior of the IActivity interface.
// Through it the same methods are able to work on members of four different classes.

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();

            workflowEngine.AddToWorkflow(new UploadToCloud());
            workflowEngine.AddToWorkflow(new CallWebService());
            workflowEngine.AddToWorkflow(new NotifyOwner());
            workflowEngine.AddToWorkflow(new ProcessVideo());

            workflowEngine.Run();
        }
    }
}
