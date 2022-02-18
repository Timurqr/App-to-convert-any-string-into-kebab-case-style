using System;
using System.Text.RegularExpressions;

namespace ConvertAnyStringIntoKebabCaseStyle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text convert to kebab-case-style: ");
            var inputText = (Console.ReadLine());           
            string pattern = @"[\W_]+";
            string replacement = "-";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(inputText.Trim(), replacement);           
            Console.WriteLine(result.ToLower());          
        }
    }
}
