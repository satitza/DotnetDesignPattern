namespace CommandPattern.Interface
{
    using Microsoft.Data.SqlClient;
    
    public interface ICommand
    {
        void Execute(SqlTransaction transaction);
    }
}

