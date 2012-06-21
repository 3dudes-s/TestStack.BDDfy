﻿using TestStack.BDDfy.Core;

namespace TestStack.BDDfy.Tests.Configuration
{
    public class CustomProcessor : IProcessor
    {
        public ProcessType ProcessType
        {
            get { return ProcessType.BeforeReport; }
        }

        public void Process(Core.Story story)
        {
        }
    }
}