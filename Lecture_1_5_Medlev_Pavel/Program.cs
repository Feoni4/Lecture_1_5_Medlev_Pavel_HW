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
            string textBox = "  Да пребудет с вами московское время. Следующее обретение силы ";

            
            int lengthDisplayBox = 25;
            int delayTime = 300;

            Console.ForegroundColor = ConsoleColor.Green;
            StringBuilder ticker = new StringBuilder(textBox.Remove(lengthDisplayBox, textBox.Length - lengthDisplayBox));

            //var dateTime = DateTime.Now.ToString(); 

            int i = lengthDisplayBox;
            while (true)
            {
                Console.Write($"{startPoint} {ticker}");

                Thread.Sleep(delayTime);
                Console.Clear();
                ticker.Remove(0, 1);

                ticker.Append(textBox[i]);
                if (i == textBox.Length-1)   //  dateTime.Length = 19
                    i = -1;
                i++;
            }       
        }
    }
}
