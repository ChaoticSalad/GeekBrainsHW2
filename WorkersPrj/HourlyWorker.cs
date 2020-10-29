using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersPrj
{
    class HourlyWorker : AbstractWorker
    {
        public HourlyWorker(string Name, string Surname, sbyte Age) : base(Name, Surname, Age)
        {

        }

        public override void CountSalary(double hourlyRate)
        {
            this.monthSalary = Convert.ToDecimal(20.8 * 8 * hourlyRate);
        }
    }
}
