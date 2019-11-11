using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Workflow_Engine
{
    public class CallWebServide : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }
}
