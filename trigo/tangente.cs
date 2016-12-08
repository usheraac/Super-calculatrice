using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trigo
{
    public class tan:computer.Computer
    {

        public string Name
        {
            get { return "tan"; }
        }

        public double Execute(params string[] values)
        {
            double result = 0;

            double val = 0;

            foreach (string value in values)
            {
                try
                {
                    val = Convert.ToDouble(value);

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

            result = Math.Tan((val* Math.PI)/180);
            return result;
        }
    }
}
