namespace InterpreterPattern.Class
{
    using Interface;
    
    public class AndExpression : IExpression
    {
        private readonly IExpression _left;

        private readonly IExpression _right;

        public AndExpression(IExpression left, IExpression right)
        {
            this._left = left;
            this._right = right;
        }
        
        public string Interpret()
        {
            return $"{this._left.Interpret()} AND {this._right.Interpret()}";
        }
    }
}
