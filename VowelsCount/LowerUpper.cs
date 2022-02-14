using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsCount
{
    internal class LowerUpper
    {
       
        public static void Main()
        {
            string st;
            char[] a;
            int len, i;
            len = 0;
            char ch;
            Console.WriteLine("Replace LowerCase Characters by UpperCase and UpperCase Characters by LowerCase  :");
            Console.WriteLine(" ");
            Console.Write("Enter the string : ");
            st = Console.ReadLine();
            len = st.Length;
            a = st.ToCharArray(0, len); 

            Console.Write("\nAfter conversion, the string is : ");
            for (i = 0; i < len; i++)
            {
                ch = a[i];
                if (Char.IsLower(ch))
                {
                    Console.Write(Char.ToUpper(ch));
                }
                else
                {
                    Console.Write(Char.ToLower(ch));
                }
            }
            Console.WriteLine(" ");
        }
    }
}

