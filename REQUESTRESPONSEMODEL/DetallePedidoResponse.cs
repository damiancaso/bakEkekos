using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class DetallePedidoResponse
    {
        public int IdDetallePedido { get; set; }

        public int? IdPedido { get; set; }

        public int? IdProducto { get; set; }

        public int? IdUsuario { get; set; }

    }
}
