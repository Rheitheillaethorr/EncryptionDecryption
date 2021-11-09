using System;
using System.Text;
using System.Linq;
namespace EncryptionDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            EnDeCrypt();
        }
        static void EnDeCrypt()
        {
            
            Console.WriteLine("Write text which you want to encrypt");
            string givenText = Console.ReadLine();
            Console.WriteLine("Write number between (-6, 6)");
            Console.WriteLine("If you use for example encryption with number 2, you can decrypt it with -2");
            string givenNumber = Console.ReadLine();
            string[] AnswerArray = new string[givenText.Length];
            try
            {
                int cryptionNumber = int.Parse(givenNumber);
                if (cryptionNumber > 6 || cryptionNumber < -6)
                {
                    Console.WriteLine("Wrong number");
                    Console.WriteLine("Try again!");
                    EnDeCrypt();
                }
                int[] CharArray = new int[givenText.Length];
                int i = 0;
                foreach (var c in givenText)
                {
                    CharArray[i++] = c;
                }
                for (int j = 0; j < givenText.Length; j++)
                {

                    if ((Enumerable.Range(65, 90).Contains(CharArray[j])) || (Enumerable.Range(97, 122).Contains(CharArray[j])))
                    {
                        CharArray[j] += cryptionNumber;
                        if (CharArray[j] < 65)
                        {
                            CharArray[j] += 26;
                        }
                        else if (CharArray[j] > 122)
                        {
                            CharArray[j] -= 26;
                        }
                        else if (CharArray[j] > 90 && CharArray[j] < 97)
                        {
                            CharArray[j] = cryptionNumber > 0 ? CharArray[j] -= 26 : CharArray[j] += 26;
                        }
                    }
                }
                for (int l = 0;l < givenText.Length; l++)
                {
                    char character = (char)CharArray[l];
                    string charToString = character.ToString();
                    AnswerArray[l] = charToString;
                }
                Console.WriteLine(String.Join("", AnswerArray));
                Console.WriteLine("Do you want to try again?");
                Console.WriteLine("'yes' or anything for no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    EnDeCrypt();
                }
                else
                {
                    Console.WriteLine("Thanks for using my program");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not an integer", givenNumber);
                Console.WriteLine("Try again!");
                EnDeCrypt();
            }
        }
    }
}