using FuelAccounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FuelAccounting
{
    public class ReportСalculator
    {
        public double GetBalance(Car car, double fueled)
        {
            return car.FuelLimit - fueled;
        }

        public int GetRestWay(Car car, int mileage)
        {
           return car.AvailableMileageLimit - mileage;
        }
    }
}
