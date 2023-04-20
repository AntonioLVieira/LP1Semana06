using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many enemies?");
            int number = int.Parse(Console.ReadLine());
            Foe [] enemies = new Foe [number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Foe f = new Foe (name);
                enemies[i] = f;
            }
            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine(enemies[i].GetName());
            }
            

        }
    }
}

