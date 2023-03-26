using System.Collections.Generic;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.ClientServices
{
    public interface IClientRepository : IRepository<Client>
    {
        public Client Get(string username, string password);
        public IEnumerable<string> GetAllNames();
        public IEnumerable<string> GetAllEmails();
        public IEnumerable<string> GetAllUsernames();
    }
}