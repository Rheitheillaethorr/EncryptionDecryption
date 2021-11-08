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
        Console.WriteLine("Write number bettwen (-6, 6)");
        int cryptionNumber = Convert.ToInt32(Console.ReadLine());
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
                char character = (char)CharArray[j];
                string test = character.ToString();
                Console.WriteLine(test);
            }
            else
            {
                char character = (char)CharArray[j];
                string test = character.ToString();
                Console.WriteLine(test);
            }

        }
        EnDeCrypt();
    }
}
}