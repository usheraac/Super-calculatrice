using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
    public class multi: computer.Computer
    {
        public string Name
        {
            get { return "multi"; }
        }

        public double Execute(params string[] values)
        {
            double result = 1;
            double val=1;
           


            foreach (string value in values)
            {
                try
                {

                    val = Convert.ToDouble(value);
                    if (val == 0) { continue; }

                    result = result * val;
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



            return result;
        }
    }
}
