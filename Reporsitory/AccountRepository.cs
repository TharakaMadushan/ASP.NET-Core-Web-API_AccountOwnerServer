using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporsitory
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        private ISortHelper<Account> _accountSortHelper;

        public AccountRepository(RepositoryContext repositoryContext, ISortHelper<Account> accountSortHelper) : base(repositoryContext)
        {
            _accountSortHelper = accountSortHelper;
        }

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }
    }
}
