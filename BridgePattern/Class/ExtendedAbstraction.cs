using BridgePattern.Abstract;
using BridgePattern.Interface;

namespace BridgePattern.Class
{
    public class ExtendedAbstraction : Abstration
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" + base._implementation.OperationImplementation();
        }
    }
}