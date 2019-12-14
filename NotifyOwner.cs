using System;

namespace WorkflowEngine
{
    public class NotifyOwner : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notifying the owner.");
        }
    }
}