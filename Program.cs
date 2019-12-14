// The goal of this activity was to show the polymorphic behavior of the IActivity interface.
// Through it the same methods are able to work on members of four different classes.

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();

            workFlow.AddToWorkflow(new UploadToCloud());
            workFlow.AddToWorkflow(new CallWebService());
            workFlow.AddToWorkflow(new NotifyOwner());
            workFlow.AddToWorkflow(new ProcessVideo());

            var engine = new WorkflowEngine();
            engine.Run(workFlow);
        }
    }
}
