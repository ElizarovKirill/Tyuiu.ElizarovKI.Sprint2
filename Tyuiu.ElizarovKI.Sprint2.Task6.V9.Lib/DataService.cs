using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ElizarovKI.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        private string getNextDay(int n)
        {
            switch (n)
            {
                case 0: return "01";
                case 1: return "02";
                case 2: return "03";
                case 3: return "04";
                case 4: return "05";
                case 5: return "06";
                case 6: return "07";
                case 7: return "08";
                case 8: return "09";
                case 9: return "10";
                case 10: return "11";
                case 11: return "12";
                case 12: return "13";
                case 13: return "14";
                case 14: return "15";
                case 15: return "16";
                case 16: return "17";
                case 17: return "18";
                case 18: return "19";
                case 19: return "20";
                case 20: return "21";
                case 21: return "22";
                case 22: return "23";
                case 23: return "24";
                case 24: return "25";
                case 25: return "26";
                case 26: return "27";
                case 27: return "28";
                case 28: return "29";
                case 29: return "30";
                case 30: return "31";
                default: throw new ArgumentException($"День должен быть от 1 до 31. Значение {n}");
            }
        }
        public string FindDateOfNextDay(int m, int n)
        {
            switch (m)
            {
                case 1: if (n >= 30) { m++; n = 0; } break;
                case 2: if (n >= 28) { m++; n = 0; } break;
                case 3: if (n >= 30) { m++; n = 0; } break;
                case 4: if (n >= 30) { m++; n = 0; } break;
                case 5: if (n >= 30) { m++; n = 0; } break;
                case 6: if (n >= 30) { m++; n = 0; } break;
                case 7: if (n >= 30) { m++; n = 0; } break;
                case 8: if (n >= 30) { m++; n = 0; } break;
                case 9: if (n >= 30) { m++; n = 0; } break;
                case 10: if (n >= 30) { m++; n = 0; } break;
                case 11: if (n >= 30) { m++; n = 0; } break;
                case 12: if (n >= 31) { throw new Exception("Значение не должно характеризоваться 31 декабря"); } break;
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
            switch (m)
            {
                case 1: return getNextDay(n) + ".01";
                case 2: return getNextDay(n) + ".02";
                case 3: return getNextDay(n) + ".03";
                case 4: return getNextDay(n) + ".04";
                case 5: return getNextDay(n) + ".05";
                case 6: return getNextDay(n) + ".06";
                case 7: return getNextDay(n) + ".07";
                case 8: return getNextDay(n) + ".08";
                case 9: return getNextDay(n) + ".09";
                case 10: return getNextDay(n) + ".10";
                case 11: return getNextDay(n) + ".11";
                case 12: return getNextDay(n) + ".12";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
        }
    }
}
