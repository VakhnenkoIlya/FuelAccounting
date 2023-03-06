using FuelAccounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelAccounting
{
    public class CarCalculator
    {
        public int GetAvailableMileageLimit(int limit, int expenditure)
        {
            return (limit / expenditure) * 100;
        }
        public int GetAvailableMileageLimit(Car car)
        {
            return (int)(car.FuelLimit / car.Expenditure)*100;
        }


        public int GetLeftToService(int lastMileage, int service, int mileage)
        {
            return lastMileage + service - mileage;
        }
        public int GetLeftToService(Car car)
        {
            return car.LastService + car.ServiceInterval - car.Mileage;
        }


        public int GetPlannedService(int lastMileage, int service)
        {
            return lastMileage + service;
        }
        public int GetPlannedService(Car car)
        {
            return car.LastService + car.ServiceInterval;
        }
    }
}
