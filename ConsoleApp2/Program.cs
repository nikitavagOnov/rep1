using System;
namespace ConsoleApplication
{
    class OurClass
    {
        static void Main(string[] args)
        {
            float num1, num2, sum, multiply, sub, div = 0;
            string errDiv, line, line2;

            while (true)
            {
                Console.Write("Введите первое число: ");
                line = Console.ReadLine();
                if (!float.TryParse(line, out num1))
                {
                    Console.WriteLine("Введите корректное значение!");
                }
                else
                    break;
            }

            while (true)
            {
                Console.Write("Введите второе число: ");
                line2 = Console.ReadLine();
                if (!float.TryParse(line2, out num2))
                {
                    Console.WriteLine("Введите корректное значение!");
                }
                else
                    break;
            }

            sum = num1 + num2; sub = num1 - num2; multiply = num1 * num2;

            if (num2 == 0)
            { errDiv = "Деление на 0!"; }
            else
            {
                div = num1 / num2;
                errDiv = Convert.ToString(div);
            }

            Console.WriteLine("\n{0} + {1} = {2} \n" +
                "{0} - {1} = {3} \n" +
                "{0} * {1} = {4}\n" +
                "{0} / {1} = {5}", num1, num2, sum, sub, multiply, errDiv);
            Environment.Exit(0);
        }
    }
}
