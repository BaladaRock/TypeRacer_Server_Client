using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TypeRacer_Server
{
    public class ContestText
    {
        private const string Path = @"D:\ProgramData\JuniorMind\OOP\(5.) Retea\TypeRacer_Server_Client\Texts.txt";

        public string GetText()
        {
            List<string> lines = GetLines().ToList();
            var random = new Random();
            int randomLine = random.Next(lines.Count);
            return lines[randomLine];
        }

        private IEnumerable<string> GetLines()
        {
            return File.ReadAllLines(Path);
        }
    }
}