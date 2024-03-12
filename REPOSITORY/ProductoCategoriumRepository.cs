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
    public class ProductoCategoriumRepository : CrudRepository<ProductoCategorium>, IProductoCategoriumRepository
    {
        public GenericFilterResponse<ProductoCategorium> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
