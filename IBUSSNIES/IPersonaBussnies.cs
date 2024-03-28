using EKEKOSDATABASEMODEL;
using REQUESTRESPONSEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBUSSNIES
{
    public interface IPersonaBussnies : ICrudBussnies<PersonaRequest, PersonaResponse>
    {
        PersonaResponse BuscarPorNombrePersona(string person);

        VwPersona ObtenerVistaPersona(string person);
    }
    
}
