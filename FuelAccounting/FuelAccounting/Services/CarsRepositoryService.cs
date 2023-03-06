using FuelAccounting.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelAccounting.Services
{
    public class CarsRepositoryService
    {
        private readonly ApplicationContext db;
        public CarsRepositoryService()
        {
            db = new ApplicationContext();
            db.Database.EnsureCreated();
            db.Cars.Load();
        }
        public void Create(Car model)
        {
            if(model== null) return;
            db.Cars.Add(model);    
            db.SaveChanges();
        }
        public void Delete(Car model)
        {
            db.Cars.Remove(model);
            db.SaveChanges();
        }
        public void UpdateAfterReport(Car newModel, Car oldModel)
        {
            var car = db.Cars.Find(oldModel.Id);
            if (car != null)
            {
                car.Mileage = newModel.Mileage;
                car.FuelLimit = newModel.FuelLimit;
                //car.LeftToService = newModel.LeftToService;
                car.AvailableMileageLimit = newModel.AvailableMileageLimit;
                db.SaveChanges();
            }
        }
        public void UpdateLimit(Car model, int newLimit)
        {
            if (model == null) return;
            var car = db.Cars.Find(model.Id);
            if (car != null)
            {
                car.FuelLimit += newLimit;
                db.SaveChanges();
            }
        }
        public void UpdateLastService(Car model, int newService)
        {
            if (model == null) return;
            var car = db.Cars.Find(model.Id);
            if (car != null)
            {
                car.LastService = newService;
                db.SaveChanges();
            }
        }
        public void UpdateExpenditure(Car model, int newExpenditure)
        {
            if(model == null) return;
            var car = db.Cars.Find(model.Id); 
            if (car != null) 
            {
                car.Expenditure = newExpenditure;
                db.SaveChanges();
            }
        }
        public void Update(Car newModel, Car oldModel)
        {
            var car = db.Cars.Find(oldModel.Id);
            if (car != null)
            {
                car.Model = newModel.Model;
                car.Mileage = newModel.Mileage;
                car.Expenditure = newModel.Expenditure;
                car.ServiceInterval = newModel.ServiceInterval;
                car.NumberPlank = newModel.NumberPlank;
                car.FuelLimit = newModel.FuelLimit;
                db.SaveChanges();
            }
        }
        public List<Car> GetAll()
        {
            return db.Cars.Include(c=>c.Reports).ToList();
        }
    }
}
