using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ToDoApp
{
    public class CreateToDoDatabase
    {
        SQLiteAsyncConnection database;
        public CreateToDoDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<ToDoItem>().Wait();
        }
        
        public Task<List<ToDoItem>> GetItemsAsync()
        {
            return database.Table<ToDoItem>().ToListAsync();
        }
    }
}
