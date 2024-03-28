using EKEKOSDATABASEMODEL;
using REQUESTRESPONSEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBUSSNIES
{
    public interface IUsuarioBussnies : ICrudBussnies<UsuarioRequest, UsuarioResponse>
    {
        UsuarioResponse BuscarPorNombreUsuario(string username);

        VwUsuario ObtenerVistaUsername(string username);
    }
}
