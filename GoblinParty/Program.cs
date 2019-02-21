using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using System.Configuration;


namespace GoblinParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string provider = ConfigurationManager.AppSettings["provider"];

            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    Console.WriteLine("Connection Error");
                    Console.ReadLine();
                    return;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    Console.WriteLine("Command Error");
                    Console.ReadLine();
                    return;
                }

                command.Connection = connection;

                command.CommandText = "Select * From Cards";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["CardId"]} " + $"{dataReader["Name"]}");
                    }
                }

                Console.ReadLine();
            }







            //  Game game = new Game();
            //  game.StartGame();

            /*Player player = new Player();

            Dice dr = new Dice();

            Console.WriteLine("Press 'r' to Roll!");
            while (Console.ReadKey(true).Key == ConsoleKey.R)
            {
                dr.rollFiveDSix();
            }*/
        }
    }
}
