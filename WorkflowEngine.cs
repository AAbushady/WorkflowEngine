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

        public void AddToWorkflow(IActivity activity)
        {
            _workflowList.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _workflowList)
            {
                activity.Execute();
            }
        }
    }
}