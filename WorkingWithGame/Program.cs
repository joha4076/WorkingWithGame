using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WorkingWithGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerX = 0;
            int playerY = 0;
            int enemyplayerX = 0;
            int enemyplayerY = 0;

            Player n = new Player("doodie",'¤');
            Player n2 = new Player("hoodie", '&');
            Map m = new Map();

            m.DrorMap();
            m.AddPlayerAt(0, 0, n);


            Thread td1 = new Thread(() => m.AddPlayerAt(79, 22, n2));
            td1.Start();

            
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        m.move(playerX, playerY, playerX -1, playerY);
                        playerX--;
                        break;

                    case ConsoleKey.UpArrow:
                        m.move(playerX, playerY, playerX, playerY -1);
                        playerY--;
                        break;

                    case ConsoleKey.DownArrow:
                        m.move(playerX, playerY, playerX, playerY + 1);
                        playerY++;
                        break;

                    case ConsoleKey.RightArrow:
                        m.move(playerX, playerY, playerX + 1, playerY);
                        playerX++;
                        break;

                    default:
                        throw new IndexOutOfRangeException();
                        break;
                }
            }

            if(playerX < enemyplayerX)
            {
                
            }

            while(true)
            {
                switch(Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        m.move(enemyplayerX, enemyplayerY, enemyplayerX - 1, enemyplayerY);
                        enemyplayerX--;
                        break;

                    case ConsoleKey.W:
                        m.move(enemyplayerX, enemyplayerY, enemyplayerX, enemyplayerY - 1);
                        enemyplayerY--;
                        break;

                    case ConsoleKey.S:
                        m.move(enemyplayerX, enemyplayerY, enemyplayerX, enemyplayerY + 1);
                        enemyplayerY++;
                        break;

                    case ConsoleKey.D:
                        m.move(enemyplayerX, enemyplayerY, enemyplayerX + 1, enemyplayerY);
                        enemyplayerX++;
                        break;

                    default:
                        throw new IndexOutOfRangeException();
                        break;
                }
            }
        }
    }
}
