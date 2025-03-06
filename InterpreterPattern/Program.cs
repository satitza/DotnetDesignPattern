namespace InterpreterPattern
{
    using Class;
    using Interface;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Design pattern(Interpreter pattern).");

            IExpression nameCondition = new ConditionExpression("name = 'anonymous'");
            IExpression ageCondition = new ConditionExpression("age > 30");

            IExpression andCondition = new AndExpression(nameCondition, ageCondition);
            var sql = $"SELECT * FROM USER WHERE {andCondition.Interpret()}";
            
            Console.WriteLine(sql);
        }
    }
}

