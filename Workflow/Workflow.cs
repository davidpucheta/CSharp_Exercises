using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow
{
    class Workflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }

        public void AddActivityToWorkflow(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
