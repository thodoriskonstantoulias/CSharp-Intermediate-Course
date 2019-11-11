using System;

namespace Project_Workflow_Engine
{
    //Design a workflow engine that takes a workflow object and runs it.A workflow is a series of steps
    //or activities. The workflow engine class should have one method called Run() that takes a
    //workflow, and then iterates over each activity in the workflow and runs it.
    //We want our workflows to be extensible, so we can create new activities without impacting the
    //existing activities.
    class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine engine = new WorkflowEngine();
            engine.AddWorkflowObject(new VideoUploader());
            engine.AddWorkflowObject(new CallWebServide());

            engine.Run();
        }
    }
}
