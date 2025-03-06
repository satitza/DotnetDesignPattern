using InterpreterPattern.Interface;

namespace InterpreterPattern.Class
{
    public class OrExpression : IExpression
    {
        private readonly IExpression _left;

        private readonly IExpression _right;

        public OrExpression(IExpression left, IExpression right)
        {
            this._left = left;
            this._right = right;
        }
        
        public string Interpret()
        {
            return $"{this._left.Interpret()} OR {this._right.Interpret()}";
        }
    }
}

