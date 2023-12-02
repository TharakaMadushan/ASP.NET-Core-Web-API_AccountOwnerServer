using Entities.Helpers;
using Entities.Models;
using Reporsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IOwnerRepository: IRepositoryBase<Owner>
    {
        PagedList<Owner> GetOwners(OwnerParameters ownerParameters);
        Owner GetOwnerById(Guid ownerId);
        Owner GetOwnerWithDetails(Guid ownerId);
        void CreateOwner(Owner owner);
        void UpdateOwner(Owner owner);
        void DeleteOwner(Owner owner);
    }
}
