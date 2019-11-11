using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Workflow_Engine
{
    public class VideoUploader : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video...");
        }
    }
}
