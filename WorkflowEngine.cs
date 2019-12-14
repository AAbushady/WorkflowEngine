using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        private readonly IList<IActivity> _workflowList;

        public WorkflowEngine()
        {
            _workflowList = new List<IActivity>();
        }

        public void Run(IWorkFlow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                try
                {
                    activity.Execute();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Unable to process activity in workflow.");
                }
            }
        }
    }
}