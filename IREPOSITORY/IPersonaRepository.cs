using EKEKOSDATABASEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IREPOSITORY
{
    public interface IPersonaRepository : ICrudRepository<Persona>
    {
        Persona obtenerPorPersona(string username);

        VwPersona obtenerVistaPersona(string username);
    }
}
