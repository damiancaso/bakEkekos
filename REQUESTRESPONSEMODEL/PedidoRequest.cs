using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REQUESTRESPONSEMODEL
{
    public class PedidoRequest
    {
        public int IdPedido { get; set; }
        public DateTime? HoraFechaPedido { get; set; }
        public DateTime? HoraFechaLlegada { get; set; }
        public int? NroComensales { get; set; }
        public int? IdColaborador { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdMetodoPago { get; set; }
        public int? IdMesa { get; set; }
        public int? IdTipoPedido { get; set; }

    }
}
