using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_notes
{
    class Program
    {
        static void Main()
        {
            Enemy enemy1 = new Enemy(100,0,0);


            Enemy enemy2 = new Enemy(health: 100, x: 1, y: 1);
            

            Console.WriteLine($"Enemy1: HP: {enemy1.GetHealth()} X: {enemy1.GetX()} Y: {enemy1.GetY()}");
            Console.WriteLine($"Enemy2: HP: {enemy2.GetHealth()} X: {enemy2.GetX()} Y: {enemy2.GetY()}");

            Console.ReadKey();



        }
    }

    class Enemy
    {
        public Enemy(int health, int x, int y)
        {
            _health = health;
            _x = x;
            _y = y;

        }

         int _health;
         int _x;
         int _y;

        public int GetHealth()
        {
            return _health;
        }
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }
    }
}
