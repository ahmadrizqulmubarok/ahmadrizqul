using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1.Conrollers
{
    internal class MonitorController
    {
        private MonitorRepository repository;

        public MonitorController()
        {
            repository = new MonitorRepository();
        }

        public void AddMonitor(string merek, string cc, decimal harga, string jenis)
        {
            repository.InsertMonitor(merek, cc, harga, jenis);
        }

        public void UpdateMonitor(string merek, string cc, decimal harga, string jenis)
        {
            repository.UpdateMonitor(merek, cc, harga, jenis);
        }

        public void DeleteMonitor(string merek)
        {
            repository.DeleteMonitor(merek);
        }

        public DataTable GetAllMonitors()
        {
            return repository.GetAllMonitors();
        }

    }
}
