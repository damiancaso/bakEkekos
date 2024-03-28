using EKEKOSDATABASEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IREPOSITORY
{
    public interface IUsuarioRepository : ICrudRepository<Usuario>
    {

        Usuario obtenerPorUsername(string username);

        VwUsuario obtenerVistaUsuario(string username);
    }
    
}
