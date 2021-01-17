// ДЗ №1 задание 2
using System;
using static System.Console;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {            
            string str1 ="";
            
            Write("Введите 6-значный номер трамвайного билета: ");
                str1 = ReadLine();
                str1 = str1.PadRight(6);
                int[] numparts=new int[6];                
                for (int i=0; i<6; ++i)
                {
                    numparts[i] = Convert.ToInt32(str1.Substring(i, 1));
                }
            int p1=0, p2=0;
            for (int i = 0; i < 3; ++i)
            {
                p1 += numparts[i];
                p2 += numparts[i+3];
            }
            WriteLine(p1+"  "+p2);
            if (p1 == p2) { 
                WriteLine("Билет счастливый!"); 
            }
            else
            {
                WriteLine("Билет не является счастливым!");
            }
            
        }
    }
}
