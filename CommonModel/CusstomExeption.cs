using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModel
{
    public class CusstomExeption : Exception
    {
        public string CodigoError { get; set; } = "";
        public string MensajeUsuario { get; set; } = "";

        public CusstomExeption() : base()
        {

        }

        public CusstomExeption(string CodigoError, string MensajeUsuario)
        {
            this.CodigoError = CodigoError;
            this.MensajeUsuario = MensajeUsuario;
        }
    }
}
