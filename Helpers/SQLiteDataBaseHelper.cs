using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViagemCusto.Models;
using Intents;

namespace ViagemCusto.Helpers
{
    public class SQLiteDataBaseHelper 
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDataBaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<pedagio>().Wait();
        }

        public Task<int> Insert(pedagio p)
        {
            return _conn.InsertAsync(p);
        }

        public Task<int> Delete(int id)
        {
            return _conn.Table<pedagio>().DeleteAsync();
        }

        public Task<List<pedagio>> GetAll()
        {
            return _conn.Table<pedagio>().ToListAsync();
        }
    }

}
