using System;

namespace WorkflowEngine
{
    public class UploadToCloud : IActivity
    {

        public void Execute()
        {
            Console.WriteLine("Uploading to cloud.");
        }
    }
}