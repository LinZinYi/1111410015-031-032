using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace _1111410015_林姿吟031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList words = new ArrayList();
            ArrayList Ans=new ArrayList();
            string str;
            int count = 0;
            Console.Write("words=");
            str = Console.ReadLine();

            words.AddRange(str.Split(' ').ToArray());
            char x;
            Console.Write("x=");
            x= Convert.ToChar(Console.ReadLine().ToLower());

            if (words.Count <= 50 && str.Length <= 50)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (Convert.ToString(words[i]).IndexOf(x) != -1)
                    {
                        Ans.Add(i);
                        count++;
                    }
                }

                if (count == 0) 
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.Write("[");
                    foreach (int s in Ans)
                    {
                        Console.Write(s + " ");
                    }
                    Console.WriteLine("]");
                }
            }



        }
    }
}
