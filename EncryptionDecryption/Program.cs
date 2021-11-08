using System;
using System.Text;

namespace EncryptionDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ABCDEFGHI";
            int i = 0;
            int[] array1 = new int[str.Length];
            foreach (var c in str)
            {
                array1[i++] = c;
            }
            char character = (char)array1[2];
            string test = character.ToString();
            Console.WriteLine(test);


        }
    }
}