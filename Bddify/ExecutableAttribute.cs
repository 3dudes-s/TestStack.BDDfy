﻿using System;

namespace Bddify
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class ExecutableAttribute : Attribute
    {
        public ExecutableAttribute(int order)
        {
            Order = order;
        }

        public int Order { get; private set; }
        public bool Asserts { get; set; }
    }
}