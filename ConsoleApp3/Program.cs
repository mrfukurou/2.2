using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите пол\nДля женских имен - ж\nДля мужских имен - м\n");
                string n = Convert.ToString(Console.ReadLine());
                if (n == "ж")
                    Console.WriteLine("Женские имена: Мария, Виолетта, Юлия, Алина, Ирина");
                else if (n == "м") Console.WriteLine("Мужские имена: Денис, Михаил, Никита, Богдан, Дмитрий");
                else Console.WriteLine("Некорректный ввод данных");
        }
    }
}
