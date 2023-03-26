using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace ServiceLayer.Services.Repositories.ClientServices
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {

        public CustomerAccountingContext CustomerAccountingContext
        {
            get { return Context as CustomerAccountingContext; }
        }
        public ClientRepository(CustomerAccountingContext context) : base(context)
        {
        }

        public Client Get(string username, string password)
        {
            return Context.Set<Client>().Single(x => x.ClientUsername.Equals(username) && x.ClientPassword.Equals(password));
        }

        public IEnumerable<string> GetAllNames()
        {
            return Context.Set<Client>().Select(x => x.ClientFullName).ToList();
        }

        public IEnumerable<string> GetAllEmails()
        {
            return Context.Set<Client>().Select(x => x.ClientEmail).ToList();
        }

        public IEnumerable<string> GetAllUsernames()
        {
            return Context.Set<Client>().Select(x => x.ClientUsername).ToList();
        }

        /// <summary>
        /// Каскадное удаление.
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            List<ProductOrder> productOrders = Context.Set<ProductOrder>().Where(x => x.ClientId == id).ToList();
            Context.Set<ProductOrder>().RemoveRange(productOrders);
            Client c = Context.Set<Client>().Find(id);
            Context.Set<Client>().Remove(c);
        }
    }
}