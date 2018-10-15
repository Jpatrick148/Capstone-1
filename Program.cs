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

            do
            {
                Console.WriteLine("Please enter a word to be Translated to Pig Latin.");

                string userInput = Console.ReadLine();
                //int vIndex = Latin.VowelCheck(userInput);

                

                string[] words = userInput.Split(' ',',');
                foreach (var word in words)
                {
                    int vIndex = Latin.VowelCheck(word);


                    if (vIndex == 0)
                    {
                        Console.Write(word + "way" + " ");
                    }

                    //string first = userInput.Substring(0, vIndex);

                    //string last = userInput.Substring(vIndex);
                    else
                    {

                        string first = word.Substring(0, vIndex);

                        string last = word.Substring(vIndex);

                        Console.Write(last + first + "ay" + " ");
                    }

                    //Console.WriteLine(last + first + "ay");
                }

                Console.ReadLine();
            } while (Continue() == true);
        }

        public static bool Continue()
        {
            Console.WriteLine("Again? {Y/N}");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please Try Again.");
                return Continue();
            }
        }
    }

    class Latin
    {

        public static int VowelCheck(string word)
        {
            var vowels = new List<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            for (int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]))
                {
                    return i;
                }

            }
            return 0;
        }

        //public static int SymbolCheck(string word)
        //{
        //    var symbol = new List<char> {'!','@','#','$','%','^','&','*','(',')','-','_','=','+','[','{',']',']','}','|',';',':','"','<','>','/','?'};
        //    for (int i = 0; i < word.Length; i++)
            
              
        //}

    }

}
