using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
                .Skip(1)
                .Select(line => Language.FromTsv(line))
                .ToList();

            // Query to find languages with "Lisp" in Predecessors
            var lispDescendants = languages.Where(lang => lang.Predecessors.Contains("Lisp"));

            // Print each language using the Prettify() method
            foreach (var lang in lispDescendants)
            {
                Console.WriteLine(lang.Prettify());
            }
        }
    }
}
