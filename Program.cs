using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DentalClearAligner
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"000092U07N_xyz_ijk_reverse.txt");
            string pattern = @"(-?([0-9]*\.[0-9]+|[0-9]+))";
            while ((line = file.ReadLine()) != null)
            {
                counter++;
                //
                MatchCollection matches = Regex.Matches(line, pattern);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                }
                System.Console.WriteLine("x:{0},y:{1},z:{2},rx:{3},ry:{4},rz:{5}", matches[0].Groups[0].Value, matches[1].Groups[0].Value,
                    matches[2].Groups[0].Value, matches[3].Groups[0].Value, matches[4].Groups[0].Value, matches[5].Groups[0].Value);
                //
            }//End while
            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
