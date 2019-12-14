using System;

namespace WorkflowEngine
{
    public class ProcessVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change video status to processing.");
        }
    }
}