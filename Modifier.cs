using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamProcessing
{
    internal class Modifier
    {
        public List<string> SortLines(List<string> lines)
        {
            lines.Sort();
            return lines;
        }

        public List<string> ToUpperCase(List<string> lines)
        {
            List<string> upperLines = new List<string>();
            foreach (var line in lines)
            {
                upperLines.Add(line.ToUpper());
            }
            return upperLines;
        }


    }
}
