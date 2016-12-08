using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
   public class sum : computer.Computer
    {
        public string Name
        {
            get { return "sum"; }
        }

        public double Execute(params string[] values)
        {
            double result = 0;

            

            foreach (string value in values)
            {
                try
                {
                    result += Convert.ToDouble(value);

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
