using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            int programCount;
            int money;
            int time;
            bool truth;

            name = "Gazinur ";
            age = 32 ;
            programCount = 1;
            money = 100;
            time = 1;
            truth = true ;

            Console.WriteLine("Здравствуйте, меня зовут " + name + ".");
            Console.WriteLine("Мне " + age + " года.");
            Console.WriteLine("Я хочу научиться делать игры, это моя " + programCount + " программа на языке C#.");
            Console.WriteLine("Когда я закончу обучение я хочу зарабатывать " + money + " доларов в " + time + " наносекунд.");
            Console.WriteLine("Достигну ли я желаемого? " + truth + "!");
        }
    }
}
