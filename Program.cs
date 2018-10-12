using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to be Translated to Pig Latin.");

            string userInput = Console.ReadLine().ToLower();
            int vIndex = Latin.VowelCheck(userInput.ToLower());
            

            Console.WriteLine(vIndex);
            Console.ReadLine();

            if (vIndex == -1)
            {
                Console.WriteLine(userInput + "way");
            }
            string first = userInput.Substring(0, vIndex);
            int userLength = userInput.Length;
            string last = userInput.Substring(vIndex, userLength);

            Console.WriteLine(first);
            Console.WriteLine(last);
            Console.ReadLine();

        }
    }

    class Latin
    {
        public static int VowelCheck(string word)
        {
            var vowels = new List<char> {'a', 'e', 'i', 'o', 'u'};
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    return i;
                }

            }
            return -1;
        }
        
      
    }

}
