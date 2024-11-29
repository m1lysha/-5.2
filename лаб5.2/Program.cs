using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        string result = ProcessString(input);
        Console.WriteLine("Результат: " + result);
    }

    static string ProcessString(string input)
    {
        StringBuilder output = new StringBuilder();

        foreach (char c in input)
        {
            output.Append(c); 

            if (IsCyrillic(c))
            {
                
                output.Append((int)c);
            }
            else if (IsLatin(c))
            {
                
                output.Append("«»");
            }
        }

        return output.ToString();
    }

    static bool IsCyrillic(char c)
    {
        return (c >= 'А' && c <= 'я'); 
    }

    static bool IsLatin(char c)
    {
        return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'); 
    }
}
