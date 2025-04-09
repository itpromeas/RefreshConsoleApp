# shortcuts

navigate between files

ctrl + tab

# constructor

ctor

# to run the app

ctrl+F5

# important extension

productivity power tool

# the generated files path

NameOfTheProject\bin\Debug

type the following in order to open the assembly: 

ildasm nameOf.exe


il = intermediate language 
ildasm = Intermediate Language Disassembler

if not working, then

follow the steps here: https://learn.microsoft.com/en-us/ef/core/cli/dotnet

# shortcut for properties

prop

# Composition vs Inheritance

Inheritance: more coupling
Composition: loose coupling


Best practice is **Composition**



# attempt solution DbConnection
Code below//

Program.cs

using System;
 
namespace Section6Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString;
            string instruction;
 
            while (true)
            {
                switch (Menu())
                {
                    case 1:
                        ///<summary>
                        ///Console queries to get connectionSting and instruction
                        ///UI practice - not directly part of exercise
                        ///</summary>
                        Console.Write("Please enter connection string for SQL DB: ");
                        connectionString = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter instrucions for the database connection: ");
                        instruction = Console.ReadLine();
                        Console.Clear();
 
                        // This portion is directly from exercise
                        var SQL = new DbCommand(new SqlConnection(connectionString), instruction);
                        SQL.Execute();
 
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to go back to the menu? Y/N");
 
                        if (Console.ReadLine().ToLower() == "n")
                            Environment.Exit(0);
 
                        Console.Clear();
                        break;
 
                    case 2:
                        ///<summary>
                        ///Console query to get connectionString and instruction
                        ///UI practice - not directly part of exercise
                        ///</summary>
                        Console.Write("Please enter connection string for Oracle DB: ");
                        connectionString = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter instrucions for the database connection: ");
                        instruction = Console.ReadLine();
                        Console.Clear();
 
                        // This portion is directly from exercise
                        var Oracle = new DbCommand(new OracleConnection(connectionString), instruction);
                        Oracle.Execute();
 
                        
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to go back to the menu? Y/N");
 
                        if (Console.ReadLine().ToLower() == "n")
                            Environment.Exit(0);
 
                        Console.Clear();
                        break;
 
                    case 3:
                        Environment.Exit(0);
                        break;
 
                }
 
            }
        }
 
        public static int Menu()
        {
            short DbSelection;
 
            Console.WriteLine(String.Format(@"Please select which database you would like to connect to:
     Enter 1: SQL Database
     Enter 2: Oracle Database
     Enter 3: Exit Program"));
 
                DbSelection = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
 
                return DbSelection;
        }
    }
}
DbConnection.cs

using System;
namespace Section6Exercise
{
    
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        //private TimeSpan Timeout;
        protected bool isConnected;
 
        public DbConnection(string connString)
        {
            if (String.IsNullOrWhiteSpace(connString))
                throw new ArgumentNullException("A connection string is required to obtain a DB Connection");
            else
            ConnectionString = connString;
        }
 
        public abstract void Open();
 
        public abstract void Close();
 
    }
}
SqlConnecction.cs

using System;
namespace Section6Exercise
{
    public class SqlConnection : DbConnection
    {
        ///private bool _isOpen;
 
        public SqlConnection(string sqlConnectionString)
            : base(sqlConnectionString)
        {
            Console.WriteLine("Now using SQL connection...");
        }
        public override void Open()
        {
            if (isConnected)
                throw new InvalidOperationException("The DB you are trying to open is already open.");
 
            isConnected = true;
            Console.WriteLine($"SQL Connection has been opened using \"{ConnectionString}\"");
            
        }
 
        public override void Close()
        {
            if (isConnected == false)
                throw new InvalidOperationException("The DB you are trying to close is not open. Please open it first");
 
            isConnected = false;
            Console.WriteLine("SQL Connection has been Closed");
        }
    }
}
OracleConnection.cs

using System;
namespace Section6Exercise
{
    public class OracleConnection : DbConnection
    { 
        public OracleConnection(string oracleConnectionString)
            : base(oracleConnectionString)
        {
            Console.WriteLine("Now using Oracle connection...");
        }
        public override void Open()
        {
            if (isConnected)
                throw new InvalidOperationException("The Oracle DB is already open");
 
            isConnected = true;
            Console.WriteLine($"Oracle Connection has been opened using \"{ConnectionString}\"");
        }
 
        public override void Close()
        {
            if (isConnected == false)
                throw new InvalidOperationException("the Oracle DB was not opened. Please open before trying to close.");
 
            isConnected = false;
            Console.WriteLine("Oracle Connection has been Closed");
        }
    }
}





DbCommand.cs

using System;
namespace Section6Exercise
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbInstruction;
 
        public DbCommand(DbConnection dbConnection, string dbInstruction)
        {
            if (dbConnection == null)
                throw new NullReferenceException("No Active Database Connection");
            if (String.IsNullOrEmpty(dbInstruction))
                throw new NullReferenceException("Instruction is non-existant. Please add one in order to proceed");
 
            _dbConnection = dbConnection;
            _dbInstruction = dbInstruction;
        }
 
        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Executing the instruction: \"{_dbInstruction}\"");
            _dbConnection.Close();
        }
    }
}
