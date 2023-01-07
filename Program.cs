using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            while (true)
            {
                Console.Write("Bir input giriniz: ");
                string? input = Console.ReadLine();
                if (Equals(input, exit))
                {
                    Console.WriteLine("Program sonlandırıldı...");
                    break;
                }
                if (input != null)
                    Console.WriteLine("{0} girdisinin palindrome olabilmesi icin gereken minimum insertion sayisi {1} olmaktadir...",input,minimumInsertion(input.ToCharArray(), 0, input.Length - 1));
            }

        }
        static int minimumInsertion(char[] word, int first, int last)
        {
            if (first > last)
            {
                return int.MaxValue;
            }
            if (first == last)
            {
                return 0;
            }
            if (first == last - 1)
            {
                return (word[first] == word[last]) ? 0 : 1;
            }

            return (word[first] == word[last]) ?
                    minimumInsertion(word, first + 1, last - 1) :
                    (Math.Min(minimumInsertion(word, first, last - 1),
                    minimumInsertion(word, first + 1, last)) + 1);


        }
    }
}
