using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentResultInfo s = new StudentResultInfo("Payal Bannagre", 1041, 75, 78, 80, 79, 75);
            s.CalculatePercentage();     
        }
    }
}
