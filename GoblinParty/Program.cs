﻿using System;
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
