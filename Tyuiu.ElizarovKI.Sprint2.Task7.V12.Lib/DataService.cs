using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElizarovKI.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            bool upperZone = (y <= Math.Pow(x, 2)) && (y >= 2 - x);
            bool lowerZone = (y >= 0) && y >= Math.Pow(x, 2) && (y <= 2 - x);
            if (upperZone && lowerZone)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
