namespace CommandPattern
{
    
    using Class;
    using Interface;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dotnet Design pattern(Command Pattern).");
            
            string connectionString = "Server=.;Database=TestDB;Trusted_Connection=True;";

            // สร้าง Transaction Manager
            TransactionManager transactionManager = new TransactionManager(connectionString);

            // สร้างคำสั่ง
            ICommand insertCommand1 = new InsertUserCommand("Alice", 25);
            ICommand insertCommand2 = new InsertUserCommand("Bob", 30);
            ICommand deleteCommand = new DeleteUserCommand(5); // ลบ User ID = 5

            // เพิ่มคำสั่งเข้า Queue
            transactionManager.AddCommand(insertCommand1);
            transactionManager.AddCommand(insertCommand2);
            transactionManager.AddCommand(deleteCommand);

            // Execute คำสั่งทั้งหมด (Rollback ถ้า Error)
            transactionManager.ExecuteAll();
        }
    }
}

