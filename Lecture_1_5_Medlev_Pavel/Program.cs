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
            string textBox = string.Empty;

            Console.ForegroundColor = ConsoleColor.Green;

            int lengthDisplayBox = 20;
            int delayTime = 300;
            int i = 0;
            int lengthLineBreak = 0;

            while (true)
            {
                textBox = string.Format(textStr1 + DateTime.Now.ToLongTimeString() + textStr2);

                Console.Write($" {startPoint} {textBox.Substring(i, lengthDisplayBox - lengthLineBreak)}{textBox.Substring(0, lengthLineBreak)}");
                Thread.Sleep(delayTime);
                Console.Clear();

                i++;                
                if (i == textBox.Length)
                {
                    i = 0;
                    lengthLineBreak = 0;
                }
                
                else if ( i == textBox.Length - lengthDisplayBox + lengthLineBreak)
                    lengthLineBreak++;


            }
        }
    }
}
