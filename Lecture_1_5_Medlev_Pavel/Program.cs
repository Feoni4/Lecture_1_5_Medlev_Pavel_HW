using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture_1_5_Medlev_Pavel
{
    /// <summary>
    ///  Консольное приложение для бегущей строки
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string startPoint = "\n\n\n\t\t ";
            string textStr1 = "  Да пребудет с вами московское время ";
            string textStr2 = ". Говорят и показывают все телестанции страны. ";
            string textBox = string.Format(textStr1 + DateTime.Now.ToLongTimeString() + textStr2);

            int lengthDisplayBox = 40;
            int delayTime = 200;

            Console.ForegroundColor = ConsoleColor.Green;
            StringBuilder ticker = new StringBuilder(textBox.Remove(lengthDisplayBox, textBox.Length - lengthDisplayBox));

            int i = lengthDisplayBox;
            while (true)
            {
                Console.Write($"{startPoint} {ticker}");

                Thread.Sleep(delayTime);
                Console.Clear();
                ticker.Remove(0, 1);

                ticker.Append(textBox[i]);
                if (i == textBox.Length-1)
                {
                    i = -1;
                    
                }       
                
                i++;

            }       
        }
    }
}
