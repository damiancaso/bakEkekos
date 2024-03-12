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
    public class DetallePedidoRepository : CrudRepository<DetallePedido>, IDetallePedidoRepository
    {
        public GenericFilterResponse<DetallePedido> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
