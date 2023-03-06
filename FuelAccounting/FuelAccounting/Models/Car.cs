namespace FuelAccounting.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string NumberPlank { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public double Expenditure { get; set; }
        public double FuelLimit { get; set; }
        public int ServiceInterval { get; set; }
        public string FuelType { get; set; }
        public int LastService { get; set; }
        public int AvailableMileageLimit { get; set; }

        public ICollection<DailyReport> Reports { get; set; }

    }
}