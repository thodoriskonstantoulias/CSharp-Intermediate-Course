using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Workflow_Engine
{
    public class WorkflowEngine
    {
        private List<IWorkFlow> _list = new List<IWorkFlow>();

        public void AddWorkflowObject(IWorkFlow obj)
        {
            _list.Add(obj);
        }
        public void RemoveWorkflowObject(IWorkFlow obj)
        {
            _list.Remove(obj);
        }
        public void Run()
        {
            foreach (var item in _list)
            {
                item.Execute();
            }
        }
    }
}
