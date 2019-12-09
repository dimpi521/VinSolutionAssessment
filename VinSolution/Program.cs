using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that parses a sentence and replaces each word with the following: first letter, number of distinct characters between first and last character, and last letter.  For example, Smooth would become S3h.  Words are separated by spaces or non-alphabetic characters and these separators should be maintained in their original form and location in the answer.
            try
            {
                var sentence = Console.ReadLine();
                var words = sentence.Split();
                StringBuilder result = new StringBuilder();
                foreach (string w in words)
                {
                    if (w.Length - 2 > 0)
                    {
                        var uniqueChars = String.Join("", w.Substring(1, w.Length - 2).Distinct());
                        result.AppendFormat("{0}{1}{2}", w[0], uniqueChars.Length, w[w.Length - 1]);
                        result.Append(" ");
                    }
                    else
                    {
                        result.Append(w);
                        result.Append(" ");
                    }
                }
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
























