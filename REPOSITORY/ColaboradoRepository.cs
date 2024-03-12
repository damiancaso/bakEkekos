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
    public class ColaboradoRepository : CrudRepository<Colaborador>, IColaboradorRepository
    {
        public GenericFilterResponse<Colaborador> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
