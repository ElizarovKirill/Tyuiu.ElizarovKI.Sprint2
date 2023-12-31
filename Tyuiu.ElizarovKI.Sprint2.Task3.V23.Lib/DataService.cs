﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElizarovKI.Sprint2.Task3.V23.Lib
{
    public class DataService : ISprint2Task3V23
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = x * (Math.Pow(((x + 1) / (x - 1)), x));
            }
            else
            {
                if (x == 0)
                {
                    y = Math.Round((Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2)) - 17) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 3), 3);
                }
                else
                {
                    if ((x > -27) && (x < 2))
                    {
                        y = Math.Pow(3 + 1 / Math.Pow(x, 2), x);
                    }
                    else
                    {
                        if (x < -27)
                        {
                            y = Math.Round(x + 10 * x - (1 / Math.Pow(x, 2)), 3);
                        }
                    }
                }
            }


            return y;
        }
    }
}
