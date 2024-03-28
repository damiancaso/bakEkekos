using EKEKOSDATABASEMODEL;
using REQUESTRESPONSEMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBUSSNIES
{
    public interface IRolBussnies : ICrudBussnies<RolRequest,RolResponse>
    {
        RolResponse BuscarPorNombreRol(string role);
    }
}
