using EKEKOSDATABASEMODEL;
using IREPOSITORY;
using REQUESTRESPONSEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY
{
    public class UserSesionRepository : CrudRepository<UserSesion>, IUserSesionRepository
    {
        public GenericFilterResponse<UserSesion> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
