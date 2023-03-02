using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rubToUsd = 76, usdToRub = 75, euroToRub = 80, rubToEuro = 81, usdToEuro = 2, euroTousd = 1;

            float rubleBalance;

            float dollarBalance;

            float euroBalance;

            string userInput;

            string stopWord = "exit";

            bool canExamination = true;

            float currencyCount;

            Console.WriteLine(" Добро пожаловать в обменник валют, здесь вы можете обменять рубли на доллары, доллары на рубли, рубли на евро и евро на рубли ");

            Console.Write(" Введите баланс рублей ");
            rubleBalance = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите баланс долларов ");
            dollarBalance = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите баланс евро ");
            euroBalance = Convert.ToInt32(Console.ReadLine());

            while (canExamination)
            {
                Console.WriteLine(" 1 - обменять рубли на доллары ");
                Console.WriteLine(" 2 - обменять доллары на рубли ");
                Console.WriteLine(" 3 - обменять рубли на евро ");
                Console.WriteLine(" 4 - обменять евро на рубли ");
                Console.WriteLine(" 5 - обменять доллары на евро ");
                Console.WriteLine(" 6 - обменять евро на доллары ");
                userInput = Console.ReadLine();
               
                if (userInput == stopWord)
                {
                    canExamination = false;
                }
                
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine(" Обмен рублей на доллары ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                        
                        if (rubleBalance >= currencyCount)
                        {
                            rubleBalance -= currencyCount;
                            dollarBalance += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей ");
                        }
                        break;
                    
                    case "2":
                        Console.WriteLine(" Обмен долларов на рубли ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                       
                        if (dollarBalance >= currencyCount)
                        {
                            dollarBalance -= currencyCount;
                            rubleBalance += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во долларов ");
                        }
                        break;
                   
                    case "3":
                        Console.WriteLine(" Обмен рублей на евро ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                       
                        if (rubleBalance >= currencyCount)
                        {
                            rubleBalance -= currencyCount;
                            euroBalance += currencyCount / rubToEuro;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во рублей ");
                        }
                        break;
                   
                    case "4":
                        Console.WriteLine(" Обмен Евро на рубли ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                        
                        if (euroBalance >= currencyCount)
                        {
                            euroBalance -= currencyCount;
                            rubleBalance += currencyCount * euroToRub;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во евро ");
                        }
                        break;
                        
                    case "5":
                        Console.WriteLine(" Обмен доллары на евро ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                       
                        if (dollarBalance >= currencyCount)
                        {
                            dollarBalance -= currencyCount;
                            euroBalance += currencyCount * usdToEuro;
                        }
                        else 
                        {
                            Console.WriteLine(" Недопустимое кол-во долларов ");
                        }
                        break;
                        
                    case "6":
                        Console.WriteLine(" Обмен евро на доллары ");
                        Console.Write(" Сколько вы хотите обменять ");
                        currencyCount = Convert.ToInt32(Console.ReadLine());
                       
                        if (euroBalance >= currencyCount)
                        {
                            euroBalance -= currencyCount;
                            dollarBalance += currencyCount * euroTousd;
                        }
                        else
                        {
                            Console.WriteLine(" Недопустимое кол-во евро ");
                        }
                        break;
                }
               
                Console.WriteLine(" Ваш баланс рублей " + rubleBalance + " баланс долларов " + dollarBalance + " баланс евро " + euroBalance);
            }
        }
    }
}