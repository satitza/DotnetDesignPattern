namespace CommandPattern.Class
{
    using Interface;
    using Microsoft.Data.SqlClient;
    
    public class DeleteUserCommand : ICommand
    {
        private int _userId;

        public DeleteUserCommand(int userId)
        {
            _userId = userId;
        }
        
        public void Execute(SqlTransaction transaction)
        {
            string query = "DELETE FROM Users WHERE Id = @UserId";
            using (SqlCommand cmd = new SqlCommand(query, transaction.Connection, transaction))
            {
                cmd.Parameters.AddWithValue("@UserId", _userId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
