using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
   public class diff : computer.Computer
    {
        public string Name
        {
            get { return "diff"; }
        }

        public double Execute(params string[] values)
        {
            double result=0;
            double val=0;
            int i = 0;
            double  a = 0 ;
            double  b = 0 ;



            foreach (string value in values)
            {
                try
                {
                  
                    val = Convert.ToDouble(value);
                    if (i == 0) { a = val; }
                    else { b += val; }
                    i++;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.", value);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.", value);
                }
            }

            result = a - b;
            return result;
        }
    }
}
