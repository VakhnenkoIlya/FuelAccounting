using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelAccounting.Model
{
    public class DailyReport
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public int Mileage { get; set; }
        public double Fueled { get; set; }  
        public int CarId { get; set; }  
        public double Balance { get; set; }
        public double RestWay { get; set; } 
        public Car Car { get; set; }
    }
}
