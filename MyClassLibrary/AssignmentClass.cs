using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class AssignmentClass
    {
        public string greadCalculate(int score) 
        {
            if(score >= 80)
            {
                return "A";
            }
            else if (score >= 75 && score <= 79)
            {
                return "B+";
            }
            else if (score >= 70 && score <= 74)
            {
                return "B";
            }
            else if (score >= 65 && score <= 69)
            {
                return "C+";
            }
            else if (score >= 60 && score <= 64)
            {
                return "C";
            }
            else if (score >= 55 && score <= 59)
            {
                return "D+";
            }
            else if (score >= 50 && score <= 54)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public double getDistance( int x1, int y1, int x2, int y2)
        {
            double x = x2 - x1;
            double y = y2 - y1;
            double sum = Math.Pow(x, 2) + Math.Pow(y, 2);
            double result = Math.Sqrt( sum );
            return Math.Round(result, 2);
        }

        public int getFactorial(int n)
        {
            if (n < 2)
            {
                return 1;
            }

            return n * getFactorial(n - 1);
        }

        public bool checkPassword(string password1, string password2)
        {
            if (password1.Length >= 3 && password2.Length >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
