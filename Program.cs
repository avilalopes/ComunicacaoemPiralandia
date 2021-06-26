using System;
using System.Linq;

namespace CShp_StringReverse
{
        class URI
    {
        public static string InverteString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {   
            Console.WriteLine("Informe a sequência de números: ");                  
            string n = Console.ReadLine();

            string v = new string(n.Reverse().ToArray());
            Console.WriteLine(); 
            Console.WriteLine($"{v}");
        }
    }
}