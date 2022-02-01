using System;
using System.Text.RegularExpressions;
using System.Text;

namespace ConvertAnyStringIntoKebabCaseStyle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text convert to kebab-case-style: ");
            var inputText = (Console.ReadLine());
            string pattern = @"\W";
            string target = "-";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(inputText, target);            
            Console.WriteLine(result.ToLower());
        }
    }
}
