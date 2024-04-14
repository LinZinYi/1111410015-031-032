using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410015_林姿吟032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一個小於等於3999的數字,num=");
            int num= Convert.ToInt32(Console.ReadLine());
            string Ans="0";

            while(num !=0)
            {
                if (num >= 1000)
                {
                    num = num - 1000;
                    Ans = Ans + "M";

                }
                else if (num >= 500)
                {
                    num = num - 500;
                    Ans=Ans+"D";
                }
                else if(num >= 100) 
                { 
                    num = num - 100;
                    Ans = Ans + "C";
                }
                else if(num >= 50)
                {
                    num = num - 50;
                    Ans = Ans + "L";
                }
                else if (num >= 10)
                {
                    num = num - 10;
                    Ans = Ans + "X";
                }
                else if( num >= 5)
                {
                    num = num - 5;
                    Ans = Ans + "V";
                }
                else
                {
                    num = num - 1;
                    Ans = Ans + "I";
                }
            }

            Ans=Ans.Replace("VIIII", "IX");
            Ans = Ans.Replace("LXXXX", "XC");
            Ans = Ans.Replace("DCCCC", "CM");
            Ans = Ans.Replace("IIII", "IV");
            Ans =Ans.Replace("XXXX", "XL");
            Ans=Ans.Replace("CCCC", "CD");
            Console.WriteLine(Ans.Remove(0, 1));
        }
    }
}
