using BridgePattern.Interface;

namespace BridgePattern.Abstract
{
    public abstract class Abstration
    {
        protected IImplementation _implementation;

        public Abstration(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" + _implementation.OperationImplementation();
        }
    }
}