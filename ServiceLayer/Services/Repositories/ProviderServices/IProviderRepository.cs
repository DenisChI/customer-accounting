using System;
using System.Collections.Generic;

namespace ServiceLayer.Services.Repositories.ProviderServices
{
    public interface IProviderRepository : IRepository<DomainLayer.Models.Provider>
    {
        public IEnumerable<string> GetAllNames();
        public IEnumerable<string> GetAllEmails();
    }
}