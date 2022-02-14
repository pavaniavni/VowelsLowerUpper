using System;
public class VowelsCo
{
    public static void Main1()
    {
        string s;
        Console.WriteLine("Enter the string : ");
        Console.WriteLine("..................");
        s = Console.ReadLine();
        int len = s.Length;
        int vow = 0, con = 0;
        for (int i = 0; i < len; i++)
        {

            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
            {
                vow++;
            }
            else
            {
                con++;
            }
        }
        Console.WriteLine("The Total number of vowel in the string is : {0}", vow);
        Console.WriteLine("The Total number of consonant in the string is : {0}\n\n", con);
    }
}
