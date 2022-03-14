using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_NEW_Massive_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Что я здесь делаю? Мама забери меня обратно!";
            string[] separatedText = text.Split(' ');

            foreach (var word in separatedText)
            {
                Console.WriteLine(word);
            }
        }
    }
}
