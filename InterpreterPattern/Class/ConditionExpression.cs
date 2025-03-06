namespace InterpreterPattern.Class
{
    using Interface;
    
    public class ConditionExpression : IExpression
    {
        private string _condition;

        public ConditionExpression(string condition)
        {
            this._condition = condition;
        }
        
        public string Interpret()
        {
            return this._condition;
        }
    }
}
