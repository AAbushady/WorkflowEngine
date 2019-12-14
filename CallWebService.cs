using System;

namespace WorkflowEngine
{
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling the web service.");
        }
    }
}