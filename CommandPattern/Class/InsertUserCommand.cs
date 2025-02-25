namespace CommandPattern.Class
{
    using Interface;
    using Microsoft.Data.SqlClient;
    
    public class InsertUserCommand : ICommand
    {
        private string _name;

        private int _age;

        public InsertUserCommand(string name, int age)
        {
            _name = name;
            _age = age;
        }
        
        public void Execute(SqlTransaction transaction)
        {
            string query = "INSERT INTO Users (Name, Age) VALUES (@Name, @Age)";
            using (SqlCommand cmd = new SqlCommand(query, transaction.Connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Name", _name);
                cmd.Parameters.AddWithValue("@Age", _age);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

