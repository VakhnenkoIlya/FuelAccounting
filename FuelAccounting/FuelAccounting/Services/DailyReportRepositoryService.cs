using FuelAccounting.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelAccounting.Services
{
    public class DailyReportRepositoryService
    {
        public ApplicationContext db;
        public DailyReportRepositoryService()
        {
            db = new ApplicationContext();
            db.Database.EnsureCreated();
            db.DailyReports.Load();
        }
        public void Create(DailyReport model)
        {
            db.DailyReports.Add(model);
            db.SaveChanges();
        }
        public void Create(ICollection<DailyReport> model)
        {
            db.DailyReports.AddRange(model);
            db.SaveChanges();
        }
        public void Delete(DailyReport model)
        {
            db.DailyReports.Remove(model);
            db.SaveChanges();
        }

        public DailyReport Read(DailyReport report)
        {
            return db.DailyReports.Find(report.Id);
        }
        public void Update(DailyReport newModel, DailyReport oldModel)
        {
            var car = db.DailyReports.Find(oldModel.Id);
            if (car != null)
            {

            }
        }

        public List<DailyReport> GetAll()
        {
            return db.DailyReports.ToList();
        }
    }
}
