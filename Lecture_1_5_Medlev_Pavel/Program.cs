using System;
using System.Threading;

namespace Lecture_1_5_Medlev_Pavel
{
    /// <summary>
    ///  Консольное приложение для бегущей строки
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string infoText = "Количество отображаемых символов в строке = {0}. Задержка = {1} мс. /esc- выход/";
            string startPoint = "\n\n\n\n\t\t\t ";
            string textStr1 = "  Московское время  ";
            string textStr2 = ". Время как вода - течет и изменяется.. ";

            Console.ForegroundColor = ConsoleColor.Green;

            int lengthDisplayBox = 15;
            int delayTime = 500;
            int i = 0;
            int lengthLineBreak = 0;

            do
            {
                Console.WriteLine(infoText, lengthDisplayBox, delayTime);
                Thread.Sleep(delayTime * 8);
                Console.Clear();

                while (!Console.KeyAvailable)
                {
                    string textBox = textStr1 + DateTime.Now.ToLongTimeString() + textStr2;

                    Console.Write($" {startPoint} {textBox.Substring(i, lengthDisplayBox - lengthLineBreak)}{textBox.Substring(0, lengthLineBreak)}");
                    Thread.Sleep(delayTime);
                    Console.Clear();

                    i++;
                    if (i == textBox.Length)
                    {
                        i = 0;
                        lengthLineBreak = 0;
                    }

                    else if (i == textBox.Length - lengthDisplayBox + lengthLineBreak)
                        lengthLineBreak++;
                }

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);            
        }
    }
}

