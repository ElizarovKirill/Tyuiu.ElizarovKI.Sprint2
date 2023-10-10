using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElizarovKI.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[,] res =
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
                { 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0 },
                { 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 },
                { 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };

            return Convert.ToBoolean(res[y-1, x-1]);
        }
    }
}
