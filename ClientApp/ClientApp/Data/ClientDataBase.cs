using ClientApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Data
{
    class ClientDataBase
    {
        private readonly SQLiteAsyncConnection database;
        public ClientDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Client>().Wait();
        }
        public Task<List<Client>> GetFriendAsync()
        {
            return database.Table<Client>().ToListAsync();
        }
        public Task<Client> GetFriendAsync(int id)
        {
            return database.Table<Client>().Where(f => f.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveFriendAsync(Client client)
        {
            if(client.ID != 0)
            {
                return database.UpdateAsync(client);
            }
            else
            {
                return database.InsertAsync(client);
            }
        }
        public Task<int> DeleteFriendAsync(Client client)
        {
            return database.DeleteAsync(client);
        }

    }
}
