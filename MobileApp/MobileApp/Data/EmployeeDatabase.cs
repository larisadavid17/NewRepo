using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using MobileApp.Models;

namespace MobileApp.Data
{
    public class EmployeeDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public EmployeeDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Employee>().Wait();
            _database.CreateTableAsync<Client>().Wait();
            _database.CreateTableAsync<Service>().Wait();
            _database.CreateTableAsync<Schedule>().Wait();
            _database.CreateTableAsync<Appointment>().Wait();
        }
        public Task<List<Employee>> GetShopListsAsync()
        {
            return _database.Table<Employee>().ToListAsync();
        }
        public Task<List<Client>> GetShopListsAsync2()
        {
            return _database.Table<Client>().ToListAsync();
        }
        public Task<List<Service>> GetShopListsAsync3()
        {
            return _database.Table<Service>().ToListAsync();
        }
        public Task<List<Schedule>> GetShopListsAsync4()
        {
            return _database.Table<Schedule>().ToListAsync();
        }
        public Task<List<Appointment>> GetShopListsAsync5()
        {
            return _database.Table<Appointment>().ToListAsync();
        }
        public Task<Employee> GetShopListAsync(int id)
        {
            return _database.Table<Employee>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<Client> GetShopListAsync2(int id)
        {
            return _database.Table<Client>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<Service> GetShopListAsync3(int id)
        {
            return _database.Table<Service>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<Schedule> GetShopListAsync4(int id)
        {
            return _database.Table<Schedule>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<Appointment> GetShopListAsync5(int id)
        {
            return _database.Table<Appointment>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveShopListAsync(Employee slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> SaveShopListAsync2(Client slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> SaveShopListAsync3(Service slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> SaveShopListAsync4(Schedule slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> SaveShopListAsync5(Appointment slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteShopListAsync(Employee slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<int> DeleteShopListAsync2(Client slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<int> DeleteShopListAsync3(Service slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<int> DeleteShopListAsync4(Schedule slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<int> DeleteShopListAsync5(Appointment slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
