using System.Collections;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkFlow
    {
        void AddToWorkflow(IActivity activity);
        void RemoveFromWorkflow(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}