using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Написать приложение, которое выведет на экран Ваше имя и фамилию.
        /// (Жду что у вас будет приложение, которое я сам запущу и где у 
        /// меня попросят ввести ФИО, после я нажму Enter и мне выдастся 
        /// сообщение – «Приветствую тебя - ФИО»)
        /// </summary>
        static void Example1()
        {
            string fName;
            Console.Write("Введите Ваше ФИО");
            fName = Console.ReadLine();

            Console.WriteLine("Приветствую тебя - " + fName);
        }
        /// <summary>
        /// Написать приложение, которое ожидает ввода нескольких чисел 
        /// и выводит на экран их сумму. (Так же как и в предыдущем примере, 
        /// только с цифрами. Мы проходили как можно из строки перевести в 
        /// число.)
        /// </summary>
        static void Example2()
        {
            int a, b;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine(a + b);
        }
    }
}
