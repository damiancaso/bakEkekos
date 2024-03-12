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
        [Key]
        [Column("id_pedido")]
        public int IdPedido { get; set; }

        [Column("hora_fecha_pedido", TypeName = "datetime")]
        public DateTime? HoraFechaPedido { get; set; }

        [Column("hora_fecha_llegada", TypeName = "datetime")]
        public DateTime? HoraFechaLlegada { get; set; }

        [Column("nro_comensales")]
        public int? NroComensales { get; set; }

        [Column("id_colaborador")]
        public int? IdColaborador { get; set; }

        [Column("id_usuario")]
        public int? IdUsuario { get; set; }

        [Column("id_metodo_pago")]
        public int? IdMetodoPago { get; set; }

        [Column("id_mesa")]
        public int? IdMesa { get; set; }
                
    }
}
