using System;
using System.Collections.Generic;
using static System.Console;


namespace AdventureGame
{
   /*
    * The Legend of Nortar
    * By Hannah Stern, 2021
    *  This work is a derivative of 
    *  "C# Adventure Game" by http://programmingisfun.com, used under CC BY. 
    *  https://creativecommons.org/licenses/by/4.0/
    */
    class Program
    {
        public Player currentPlayer = new Player();
        public bool mainLoop = true;
        public static void Main()
        {
            Game game = new Game()
            {
                Title = "The Legend of Nortar"
            };
            game.StartGame();
           
                
           

           
        }
    }
}
