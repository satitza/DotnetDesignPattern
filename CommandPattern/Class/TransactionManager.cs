namespace CommandPattern.Class
{
    using Interface;
    using Microsoft.Data.SqlClient;
    
    public class TransactionManager
    {
        private List<ICommand> _commands;

        private string _connectionString;
        
        public TransactionManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddCommand(ICommand command)
        {
            if (this._commands == null)
            {
                this._commands = new List<ICommand>();
            }
            
            this._commands.Add(command);
        }

        public void ExecuteAll()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (var command in _commands)
                    {
                        command.Execute(transaction);
                    }

                    transaction.Commit();
                    Console.WriteLine("Transaction Committed Successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction Rolled Back. Error: " + ex.Message);
                }
            }
        }
        
    }
}

