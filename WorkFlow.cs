using System.Collections.Generic;

namespace WorkflowEngine
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<IActivity> _activities = new List<IActivity>();

        public void AddToWorkflow(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void RemoveFromWorkflow(IActivity activity)
        {
            _activities.Remove(activity);
        }

        // IEnumerable was used instead of lists because adding or removing was not 
        // necessary at this part of the program.
        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}