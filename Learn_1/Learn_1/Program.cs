using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Learn_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("text\\task1.txt", Encoding.UTF8);

            string text = sr.ReadToEnd();
            Console.WriteLine(text);
            sr.Close();

            int noVowel = 0;
            int count=0;

            foreach(var i in text)
            {   
                if (Vowel(i.ToString()))
                {
                    count++;
                }
                else
                {
                    noVowel = count > noVowel ? count : noVowel;
                    count = 0;
                }

            }

            Console.WriteLine(noVowel);
        }

        static bool Vowel(string po)
        {
            string[] masVowel = { "a", "e", "y", "u", "i", "o" };
            for (int i = 0; i < masVowel.Length; i++)
            {
                if (po.ToUpper() == masVowel[i].ToUpper())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
