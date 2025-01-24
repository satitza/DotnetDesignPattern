namespace FacadePattern.Class
{
    public class Facade
    {
        protected SubSystem1 _subSystem1;

        protected Subsystem2 _subSystem2;


        public Facade(SubSystem1 subSystem1, Subsystem2 subsystem2)
        {
            this._subSystem1 = subSystem1;
            this._subSystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystem:\n";
            result += this._subSystem1.operation1();
            result += this._subSystem2.operation1();
            result += "Facade orders subsystem to perform the action:\n";
            result += this._subSystem1.operatingN();
            result += this._subSystem2.operationZ();
            return result;
        }
    }
}