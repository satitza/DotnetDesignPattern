﻿using BridgePattern.Interface;

namespace BridgePattern.Class
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }
}