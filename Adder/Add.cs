using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
    public class Adder : computer.Computer
    {
        public string Name
        {
            get { return "Adder"; }
        }

        public double Execute(params string[] values)
        {
            double result = 0;
            foreach (string v in values)
            {
                result += Convert.ToDouble(v);
            }
            return result;
        }
    }
}
